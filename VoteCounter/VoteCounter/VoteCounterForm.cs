using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VoteCounter
{
    public partial class VoteCounterForm : Form
    {
        #region Variables

        // The list of selected files stored locally in the application
        private ArrayList selectedFiles = new ArrayList();

        // The voteCounter does all of the real work.
        private VoteCounter voteCounter = new VoteCounter();

        // Random number generator
        private Random rand = new Random();

        // Task completion source is used to pause and resume the loop when generate the result of each round.
        private TaskCompletionSource<bool> _tcs;

        // Single candidate to be removed each round, just easier to record
        private string candidateToRemove;

        // Candidates to be removed each round
        ArrayList removedCandidates = new ArrayList();

        // The auditing data shown on screen
        private string result;
      
        #endregion


        #region Constructor

        /// <summary>
        /// Just the default
        /// </summary>
        public VoteCounterForm()
        {
            InitializeComponent();
            msFile.Renderer = new MenuRenderer();
        }

        #endregion

        #region Render
        private class MenuRenderer : ToolStripProfessionalRenderer
        {
            public MenuRenderer() : base(new MenuColors()) { }
        }


        private class MenuColors : ProfessionalColorTable
        {
            public override Color MenuItemSelected
            {
                get { return Color.BlueViolet; }
            }
            public override Color MenuItemSelectedGradientBegin
            {
                get { return Color.DarkViolet; }
            }
            public override Color MenuItemSelectedGradientEnd
            {
                get { return Color.BlueViolet; }
            }
            public override Color MenuItemBorder
            {
                get { return Color.Violet; }
            }
            public override Color MenuItemPressedGradientBegin
            {
                get { return Color.DarkViolet; ; }
            }
            public override Color MenuItemPressedGradientEnd
            {
                get { return Color.BlueViolet; }
            }
        }

        #endregion

        #region Events

        /// <summary>
        /// Does the real work of running the vote when hit. Loads the
        /// votes each time.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void VoteButton_Click(object sender, EventArgs e)
        {
            // Initialise relevant controls every time the button is hit
            result = "";
            ResultTextBox.Text = result;
            btnShowResults.Enabled = true;
            btnShowResults.Focus();
            MessageBox.Show("The vote is now running... Click 'Show Results' to see how each round goes!");

            // Create a new vote counter. This is a bit of a cludge, but it ensures each vote count is fresh.
            // It would die horribly if the button was hit twice and this wasn't there.
            this.voteCounter = new VoteCounter();

            // Load the votes from the selected file(s) locally stored in the application. 
            foreach (string path in selectedFiles)
            {
                this.voteCounter.LoadVotes(path);
            }

            // Check the optional votes validation method.
            int validation = CheckValidationMethod();

            // Have we finished yet? If we haven't started counting yet, the answer is no.
            bool finished = false;

            // As a matter of interest, how many rounds did this take?
            int round = 0;

            // Keep looping until the count is done. A count that is broken would be bad, though.
            while (!finished)
            {
                // Increase how many rounds this had taken
                round += 1;

                // Clears the candidates to remove at the beginning of each round
                candidateToRemove = "";
                removedCandidates.Clear();
                lbCandidatesLowest.Items.Clear();
                lbCandidatesLowest.Enabled = false;
                btnRemoveAll.Enabled = false;
                btnRemoveOne.Enabled = false;

                // Once the vote validation method is selected, disable any chnages in the running process.
                rbOriginal.Enabled = false;
                rbSequential.Enabled = false;

                // Conduct the count for this round.
                this.voteCounter.DoCount(validation);

                // Which round it is
                result += "After round " + round + " of counting: ";
                result += Environment.NewLine;

                // The number of valid and invalid votes found in that round
                result += "Valid votes: " + voteCounter.Valid;
                result += Environment.NewLine;
                result += "Invalid votes: " + voteCounter.Invalid;
                result += Environment.NewLine;

                // Remove candidates who have the lowest votes
                RemoveCandidates();

                // Create a task completion source and pause the loop 
                // As the remove results sometiems depends on user options
                this._tcs = new TaskCompletionSource<bool>();
                await this._tcs.Task;

                // Who has/have been removed, and the votes for all candidates at the end of that round unless then have been removed from counting
                PrintRemoveResults();

                // Now that the count is done, there are three possibilities.

                // Possibility 1 is that one, and only one, candidate got over 50%. 
                // (first past the post)
                if (this.voteCounter.Winner != "")
                {
                    finished = true;
                    // Generate report
                    result += "After round " + round + " of counting, " + this.voteCounter.Winner +
                        " has won the vote with " + this.voteCounter.Candidates[this.voteCounter.Winner] +
                        " out of " + (this.voteCounter.Valid + this.voteCounter.Invalid) + " votes.";
                    MessageBox.Show("All rounds have ended and you can now see the full report!");
                    btnShowResults.Enabled = false;
                    rbOriginal.Enabled = true;
                    rbSequential.Enabled = true;
                }

                // Possibility 2 is that all remaining candidates got exactly the same number of votes
                // Note: we want to prevent the situation that compares candiadates who have zero votes and viable candidates
                // (e.g. C1: votes=0, C2: votes=0, C3: votes=3, C4: votes=3),
                // In theory, this should compare C3 and C4 as lowest = viable = 1;
                // However, instead of doing it in the last round, it will jump into this condition as {C1, C2} = {C3, C4} = 2;
                // I explicit the rules in RemoveCandidates() as to eliminate the candidates who have zero votes first when such a situation occurs
                // Now this will be used to determine a final status of a ballot 
                else if (this.voteCounter.Lowest.Length == this.voteCounter.ViableCandidates.Count && !LowestHasZero())
                {                
                    finished = true;
                    // Generate report for a tie
                    result += "After round " + round + " of counting, there is a tie." + Environment.NewLine;

                    // Loop through all of those who tied and report name and votes. Yes, I know that the number
                    // of votes will be the same, because of the tie thing. But report it in case someone cares.
                    foreach (string name in this.voteCounter.Lowest)
                    {
                        result += name + " with " + this.voteCounter.Candidates[name] + " out of " +
                            (this.voteCounter.Valid + this.voteCounter.Invalid) + " votes." + Environment.NewLine;
                    }
                    MessageBox.Show("All rounds have ended and you can now see the full report!");
                    btnShowResults.Enabled = false;
                    rbOriginal.Enabled = true;
                    rbSequential.Enabled = true;
                }

                // Possibility 3 is that we have multiple candidates below 50%, and we now need 
                // to exclude the one with the lowest votes.
                else
                {
                    // Note that if there is more than one with the lowest vote, we exclue the one(s) according to the option selected
                    foreach (string c in removedCandidates)
                    {
                        this.voteCounter.RemoveCandidate(c);
                    }
                }
                this.ResultTextBox.Text = result;
            }
            this.GenerateReport(selectedFiles, result);
        }


        /// <summary>
        /// Show the round results when hit.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnShowResults_Click(object sender, EventArgs e)
        {
            this._tcs.SetResult(false);
        }


        /// <summary>
        /// Exit the application when hit.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        /// <summary>
        /// Loads the files each time when hit.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpenFiles_Click(object sender, EventArgs e)
        {
            try
            {
                // Open the CSV file(s) from anywhere on the hard drive.
                // This allows more than one CSV file to be loaded for one election.
                ArrayList tryOpenFiles = GetFilePaths();

                // Check if any file has been selected successfully,
                // If yes, then we load the files into the local arraylist of selected files,
                // and refresh some controls and enable the option to show results
                if (CheckIfAnyFileSelected(tryOpenFiles) == true)
                {
                    this.selectedFiles = tryOpenFiles;
                    result = "";
                    ResultTextBox.Text = result;
                    VoteButton.Enabled = true;
                    VoteButton.Focus();
                    rbOriginal.Enabled = true;
                    rbSequential.Enabled = true;
                    string fileLabelText = "You selected ";
                    foreach (string file in this.selectedFiles)
                    {
                        fileLabelText += System.IO.Path.GetFileName(file) + "; ";
                    }
                    fileLabelText = fileLabelText.Substring(0, fileLabelText.Length - 2);
                    lblFile.Text = fileLabelText;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }


        /// <summary>
        /// If "Remove All" is clicked, remove all candidates with the lowest votes.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRemoveAll_Click(object sender, EventArgs e)
        {
            lbCandidatesLowest.Items.Clear();
            string rmc = "";
            foreach (string c in this.voteCounter.Lowest)
            {
                rmc += c + ", ";
                // This is to prevent the duplicate when the user clicks RemoveOne first then clicks RemovesAll.
                if (!removedCandidates.Contains(c))
                {
                    removedCandidates.Add(c);
                }
            }
            MessageBox.Show("You removed " + rmc.Substring(0, rmc.Length - 2) + "!");
        }


        /// <summary>
        /// If "Remove One" is clicked, remove only the one candidate that has been selected.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRemoveOne_Click(object sender, EventArgs e)
        {
            try
            {
                candidateToRemove = lbCandidatesLowest.SelectedItem.ToString();
                lbCandidatesLowest.Items.RemoveAt(lbCandidatesLowest.SelectedIndex);
                MessageBox.Show("You removed " + candidateToRemove.ToString());
                removedCandidates.Add(candidateToRemove);
            }
            catch (Exception ex)
            {
                MessageBox.Show("You need select which candidate you wanna remove!");
            }
        }

        #endregion


        #region Functions
        /// <summary>
        /// Method to get the file path(s) of selected files.
        /// Create a new selectedFileNames arraylist each time the method is called to ensure it is fresh.
        /// The arraylist selectedFileNames stores the exact path of each csv file selected.
        /// </summary>
        /// <returns> selectedFileNames </returns>
        private ArrayList GetFilePaths()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            ArrayList selectedFileNames = new ArrayList();
            openFileDialog.InitialDirectory = "c:\\";
            openFileDialog.Filter = "Database files (*.csv)|*.csv";
            openFileDialog.FilterIndex = 0;
            openFileDialog.RestoreDirectory = true;
            openFileDialog.Multiselect = true;

            // If the user clicks "OK", files have been selected, then add them to the arraylist
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedFiles = "";
                foreach (string file in openFileDialog.FileNames)
                {
                    selectedFileNames.Add(file);
                    selectedFiles += file + ", ";
                }
                MessageBox.Show("You selected " + selectedFiles.Substring(0, selectedFiles.Length - 2));
            }
            return selectedFileNames;
        }


        /// <summary>
        /// This method is to check if any files have been successfully selected.
        /// </summary>
        /// <param name="filenames"></param>
        /// <returns> Returns false if no file is selected, otherwise returns true. </returns>     
        private bool CheckIfAnyFileSelected(ArrayList filenames)
        {
            // When the user can click "Cancel" and not successfully select any files, 
            // the arraylist of selected files will be empty.
            if (filenames.Count == 0)
            {
                MessageBox.Show("You need select at least one valid csv file!");
                return false;
            }
            else
            {
                return true;
            }
        }


        /// <summary>
        /// This method is to check the optional vote validation method.
        /// </summary> 
        /// <returns> Returns 0 when votes can a) be declared valid at the point here they become a problem (as is currently the case)
        /// Returns 1 b) votes are declared invalid if they fail to number the candidates sequentially.
        /// Otherwise returns -1.
        /// </returns>
        private int CheckValidationMethod()
        {
            int v = -1;
            if (rbOriginal.Checked == true)
            {
                v = 0;
            }
            else if (rbSequential.Checked == true)
            {
                v = 1;
            }
            return v;
        }


        /// <summary>
        /// This method is to remove candidates who have the lowest votes round.
        /// </summary>   
        private void RemoveCandidates()
        {
            // If there are multiple candidates with the same lowest votes that equal zero, remove them all in this round.
            if (this.voteCounter.Lowest.Length > 1 && LowestHasZero())
            {
                foreach (string c in this.voteCounter.Lowest)
                {
                    if (this.voteCounter.Candidates[c] == 0)
                    {
                        removedCandidates.Add(c);
                    }
                }
            }
            // If there are multiple candidates with the same lowest votes and it is not the end condition yet,
            // Check remove options to decide whether to use random coin toss or let user decide.
            else if (this.voteCounter.Lowest.Length > 1 && this.voteCounter.Lowest.Length != this.voteCounter.ViableCandidates.Count)
            {
                CheckRemoveOptions();
            }
            // If there is only one candidate with the lowest vote, directly remove that one.
            else if (this.voteCounter.Lowest.Length == 1)
            {
                candidateToRemove = this.voteCounter.Lowest[0];
                removedCandidates.Add(candidateToRemove);
            }
        }


        /// <summary>
        /// This method is to check if candidates with the lowest votes that equal zero.
        /// </summary>
        /// <returns> Returns true if such a candidate with no votes is found, otherwise returns false. </returns> 
        private bool LowestHasZero()
        {
            foreach (string c in this.voteCounter.Lowest)
            {
                if (this.voteCounter.Candidates[c] == 0)
                {
                    return true;
                }
            }
            return false;
        }


        /// <summary>
        /// This method is to check the options of removing a candidate and act correnspondingly.
        /// </summary>   
        private void CheckRemoveOptions()
        {
            // If random coid toss is selected, remove a random candidate with the lowest votes.
            if (rbCoin.Checked == true)
            {
                MessageBox.Show("Some candidates who have the same lowest votes, and use coin toss as default!");
                candidateToRemove = this.voteCounter.Lowest[rand.Next(0, this.voteCounter.Lowest.Length)];
                removedCandidates.Add(candidateToRemove);
            }
            // If user decides is selected, display all the candidates with the lowest votes that round and wait for user interaction.
            else if (rbUser.Checked == true)
            {
                lbCandidatesLowest.Enabled = true;
                btnRemoveAll.Enabled = true;
                btnRemoveOne.Enabled = true;
                MessageBox.Show("Below are the candidates who have the same lowest votes, and you decide!");
                LoadCandidatesToRemove();
            }
            // If neither random coin toss nor user decides is selected, prompt user a message.
            else
            {
                MessageBox.Show("You have to select either an option!");
            }
        }


        /// <summary>
        /// This method is to show the candidates with the lowest votes on screen.
        /// </summary>   
        private void LoadCandidatesToRemove()
        {
            foreach (string name in this.voteCounter.Lowest)
            {
                lbCandidatesLowest.Items.Add(name);
            }
            lbCandidatesLowest.Focus();
        }


        /// <summary>
        /// This method is to display who has/have been removed, and the votes for remaining candidates at the end of that round.
        /// </summary> 
        private void PrintRemoveResults()
        {
            foreach (string rm in removedCandidates)
            {
                result += "Who has been removed: " + rm;
                result += Environment.NewLine;
            }

            // The votes for all candidates at the end of that round (unless then have been removed from counting
            result += "Remaining candidates: ";
            result += Environment.NewLine;

            // LINQ - viable candidates except the ones that have been removed from the current round
            foreach (KeyValuePair<string, int> kvp in this.voteCounter.ViableCandidates.Where(x => !removedCandidates.Contains(x.Key)))
            {
                result += string.Format("Name = {0}, Votes = {1}", kvp.Key, kvp.Value);
                result += Environment.NewLine;
            }
            result += Environment.NewLine;
        }


        /// <summary>
        /// This method is to generate the report of the final result and write in a csv file after all rounds have ended.
        /// Saved in the D drive as default.
        /// </summary>
        /// <param name="inputFiles"> Input files used to generate the file name of the report. </param>
        /// <param name="reportStr"> The actual content in the report. </param>
        private void GenerateReport(ArrayList inputFiles, string reportStr)
        {
            try
            {
                string reportName = "report_of_";
                foreach (string inputFile in inputFiles)
                {
                    reportName += System.IO.Path.GetFileName(inputFile) + "; ";
                }
                reportName = reportName.Substring(0, reportName.Length - 2);
                if (CheckValidationMethod() == 0)
                {
                    reportName += "_original";
                }
                else if (CheckValidationMethod() == 1)
                {
                    reportName += "_sequential";
                }
                reportName += ".csv";
                string strFilePath = @"D:\" + reportName;

                // Create and write the csv file
                File.WriteAllText(strFilePath, reportStr);
                MessageBox.Show("The final report has been saved as " + strFilePath + "!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to generate the final report!");
            }
        }

        #endregion


    }
}
