using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.FileIO;

namespace VoteCounter
{
    /// <summary>
    /// Loads and counts votes for a variable number of candidates
    /// using optional preferential voting
    /// </summary>
    class VoteCounter
    {
        #region Properties

        /// <summary>
        /// List of all completed ballots by people loaded from a CSV file
        /// </summary>
        public List<Vote> Votes
        {
            get;
            set;
        }

        /// <summary>
        /// All candidates by name (the key) and number of votes (the value)
        /// </summary>
        public Dictionary<string, int> Candidates
        {
            get;
            set;
        }

        /// <summary>
        /// List of all candidate names (keys) generated from the Candidates dictionary. 
        /// Read only and derived value.
        /// </summary>
        public string[] CandidateNames
        {
            get
            {
                return this.Candidates.Keys.ToArray<string>();
            }
        }

        /// <summary>
        /// List of all current viable candidates by name (keys) with votes (value)
        /// </summary>
        /// <remarks>
        /// Any candidate with more than 0 votes after a counting round is considered viable.
        /// </remarks>
        public Dictionary<string, int> ViableCandidates
        {
            get
            {
                Dictionary<string, int> _viableCadidates = new Dictionary<string, int>();
                foreach (KeyValuePair<string, int> candidate in this.Candidates)
                {
                    if (candidate.Value > 0)
                    {
                        _viableCadidates.Add(candidate.Key, candidate.Value);
                    }
                }

                return _viableCadidates;
            }
        }

        /// <summary>
        /// Number of valid votes in the last count. Derived value. Read only.
        /// </summary>
        public int Valid
        {
            get
            {
                return this.Votes.Count - this.Invalid;
            }
        }

        /// <summary>
        /// Number of invalid votes in the last count. Read only.
        /// </summary>
        public int Invalid
        {
            get
            {
                return _invalid;
            }
        }
        private int _invalid = 0;

        /// <summary>
        /// The name of the winning candidate if a candidate gained 50% + 1 of the vote. Read only.
        /// </summary>
        public string Winner
        {
            get
            {
                return this.getWinner();
            }
        }

        /// <summary>
        /// A list of the names of canddiates who recived the lowest votes in the last count. Read only.
        /// </summary>
        public string[] Lowest
        {
            get
            {
                return this.getLowest();
            }
        }

        #endregion

        #region Constructor

        /// <summary>
        /// Consructor. Declares the necessary lists and dictionaries.
        /// </summary>
        public VoteCounter()
        {
            this.Votes = new List<Vote>();
            this.Candidates = new Dictionary<string, int>();
        }

        #endregion

        #region Conduct the count for the current round.

        /// <summary>
        /// Runs the count for one round
        /// </summary>
        /// <remarks>
        /// Does one round of counting. Should  continue to be
        /// called unless a winner is found or there is a tie
        /// </remarks>
        /// <param name="validationOption"></param>
        public void DoCount(int validationOption)
        {
            // Clear old candidate vote counts. We're counting anew.
            foreach (string candidate in this.CandidateNames)
            {
                // Don't clear that a candidate has been precluded or
                // they will be counted again. Precluded candidates have 
                // -1 votes
                if (this.Candidates[candidate] != -1)
                {
                    this.Candidates[candidate] = 0;
                }
            }

            // Clear old invalid vote count. We're starting again.
            this._invalid = 0;

            // Go through all of the votes
            foreach (Vote vote in this.Votes)
            {
                // Is it a good vote? Checks to see if it is invalid,
                // which at this stage means that it has one and only one 
                // first preference
                if (vote.Validate(validationOption))
                {
                    // Try and catch is just a backup in case we forgot to 
                    // validate above. Counting invalid votes is bad.
                    try
                    {
                        Console.WriteLine("Valid:");
                        foreach (KeyValuePair<string, int> kvp in vote.Votes)
                        {
                            Console.WriteLine("Key = {0}, Value = {1}", kvp.Key, kvp.Value);
                        }
                        // Find out what the first preference is, and add
                        // one vote to that candidate
                        this.Candidates[vote.GetFirstPreference(validationOption)] += 1;
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Invalid:");
                        foreach (KeyValuePair<string, int> kvp in vote.Votes)
                        {
                            Console.WriteLine("Key = {0}, Value = {1}", kvp.Key, kvp.Value);
                        }
                        // Count the vote as invalid if an exception was thrown
                        this._invalid += 1;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid:");
                    foreach (KeyValuePair<string, int> kvp in vote.Votes)
                    {
                        Console.WriteLine("Key = {0}, Value = {1}", kvp.Key, kvp.Value);                 
                    }
                    // Count the vote as invalid if it was declared invalid above
                    this._invalid += 1;
                }
            }
        }

        #endregion

        #region Load the data

        /// <summary>
        /// Loads votes from a CSV file. Assumes "," as separator, and quotation marks around text.
        /// Requires a path to be specified.
        /// </summary>
        public void LoadVotes(string path)
        {
            try
            {
                using (TextFieldParser csvParser = new TextFieldParser(path))
                {
                    // Setting up the CSV file
                    csvParser.CommentTokens = new string[] { "#" };     // Comments if present
                    csvParser.SetDelimiters(new string[] { "," });      // Separator
                    csvParser.HasFieldsEnclosedInQuotes = true;         // Quotes to donate text

                    // Read the row with the column names
                    string[] candidateNames = csvParser.ReadFields();

                    // Add the names to the list of candidates as the keys
                    foreach (string candidate in candidateNames)
                    {
                        // This only adds candidates that haven't appeared before
                        if (!this.Candidates.ContainsKey(candidate) && candidate != "")
                        {
                            this.Candidates.Add(candidate, 0);
                        }
                    }

                    // Now we start reading the votes, line by line.
                    while (!csvParser.EndOfData)
                    {
                        // Create a new vote object to work with.
                        Vote newVote = new Vote();

                        // Read in all the fields in the current row. By default these are strings.
                        string[] fields = csvParser.ReadFields();

                        int voteCount = fields.Length;
                        int candidateCount = Candidates.Count;

                        // If there are more votes in the row than candidates.
                        // Note: we record blank votes, that is, there will not be more candidates than votes.
                        if (voteCount > candidateCount)
                        {
                            bool canCount = true;
                            for (int i = candidateCount; i < voteCount; i++)
                            {
                                if (fields[i] != "")
                                {
                                    canCount = false;
                                }
                            }

                            if (canCount)
                            {
                                // For each field provided ...
                                for (int index = 0; index < candidateCount; index++)
                                {
                                    if (fields[index] != "")
                                    {
                                        newVote.Votes.Add(candidateNames[index], Convert.ToInt32(fields[index]));
                                    }
                                    else
                                    {
                                        // If it is left blank, count it as zero.
                                        // The original validation method would not care, the sequential one would reckon this vote as invalid.
                                        newVote.Votes.Add(candidateNames[index], 0);  
                                    }
                                }
                                this.Votes.Add(newVote);
                            }
                        }

                        // If the number of votes and candidates match.
                        else if (voteCount == candidateCount)
                        {
                            // For each field provided ...
                            for (int index = 0; index < candidateCount; index++)
                            {
                                // Add it and the appropriate candidate in the vote.
                                // Note that this will die horribly if there are more votes in the row than 
                                // candidates, or more candidates than votes. -- fixed. Do not read such votes.
                                if (fields[index] != "")
                                {
                                    newVote.Votes.Add(candidateNames[index], Convert.ToInt32(fields[index]));
                                }
                                else
                                {
                                    newVote.Votes.Add(candidateNames[index], 0);
                                }
                            }
                            this.Votes.Add(newVote);
                        }

                    }

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

        }

        #endregion

        #region Removing candidates (if precluded)

        /// <summary>
        /// Removes a candidate from the ballot by removing it from
        /// each vote if the candidate has been preculded. Sets
        /// the candiate's vote count to -1 to indicate preclusion.
        /// </summary>
        public void RemoveCandidate(string candidateName)
        {
            // -1 means that they have been precluded.
            this.Candidates[candidateName] = -1;
            foreach (Vote vote in this.Votes)
            {
                vote.RemoveCandidate(candidateName);
            }
        }

        #endregion

        #region Winners and losers

        /// <summary>
        /// Find out who has won, if anyone (50% + 1)
        /// </summary>
        /// <returns>
        /// Name of winning candidate
        /// </returns>
        private string getWinner()
        {
            // Calculate what 50% of valid votes looks like
            float target = this.Valid / 2;

            string winner = "";

            // Check the candidates looking for someone with more votes than
            // the target value
            foreach (KeyValuePair<string, int> candidate in this.Candidates)
            {
                if (candidate.Value > target)
                {
                    winner = candidate.Key;
                }
            }

            return winner;
        }

        /// <summary>
        /// Find out who has the current lowest number of votes
        /// </summary>
        /// <remarks>
        /// Techncially this is the lowest, but if all the
        /// remaining candidates have the same number of votes
        /// they are regarded as the lowest, even though this is
        /// technically a tie.
        /// </remarks>
        /// <returns>
        /// String array containing all candidate names with
        /// the lowest number of votes.
        /// </returns>
        private string[] getLowest()
        {
            // Find out what the lowest number of votes was

            // Set the lowest to an impossibly high value
            int target = this.Valid + 1;

            // Need to allow for two or more lowest candidates
            List<string> lowestCandidates = new List<string>();

            // Loop through all of the candidates to find out what the current 
            // lowest number of votes is.
            foreach (KeyValuePair<string, int> candidate in this.Candidates)
            {
                if (candidate.Value < target && candidate.Value > -1)
                {
                    target = candidate.Value;
                }
            }

            // Now loop through the candidates again and add all candidates with
            // the lowest votes to the array
            foreach (KeyValuePair<string, int> candidate in this.Candidates)
            {
                if (candidate.Value == target)
                {
                    lowestCandidates.Add(candidate.Key);
                }
            }

            return lowestCandidates.ToArray();
        }

        internal class Button_WOC
        {
            public Button_WOC()
            {
            }
        }

        #endregion
    }
}
