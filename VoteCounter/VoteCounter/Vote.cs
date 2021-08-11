using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace VoteCounter
{
    class Vote
    {
        #region Properties

        /// <summary>
        /// All of the preferences to each of the candidates.
        /// Candidate name is the key, preference is the value.
        /// </summary>
        public Dictionary<String, int> Votes
        {
            get;
            set;
        }

        #endregion

        #region Constructor

        /// <summary>
        /// Consructors don't get a lot more bring than this. 
        /// Initialises the candidates and their preferences.
        /// </summary>
        public Vote()
        {
            this.Votes = new Dictionary<String, int>();
        }

        #endregion

        #region Validation
        /// <summary>
        /// This checks to see if there is more than one first preference
        /// or, alternatively, no first preference. If either is true
        /// the vote is invalid.
        /// </summary>
        /// <remarks>
        /// This does not check to see if the preferences are in sequential
        /// order (for example, a preference of 5 when there are only 4 
        /// candidates) or if there are two for any preference but the
        /// first. Votes are only declared invalid when the preferences
        /// are unable to be counted, and are valid until that situation
        /// is reached.
        /// Fixed the situation above (see validationMethod = 1).
        /// </remarks>
        /// <param name="validationMethod"></param>
        /// <returns>true if it is a valid vote</returns>
        public bool Validate(int validationMethod)
        {
            // Assume the vote is invalid until proven otherwise (aka, it has
            // one and only one first preference)
            bool isValid = false;

            // If validation method is the original: votes can a) be declared valid at the point here they become a problem (as is currently the case).
            if (validationMethod == 0)
            {
                // hasFirstPreference is used to record if a first preference has 
                // been found or not. 
                bool hasFirstPreference = false;

                // Loop through the votes
                foreach (KeyValuePair<string, int> entry in Votes)
                {
                    // If this is a first preference, and no other first preference 
                    // has been found, the vote is currently valid
                    if (entry.Value == 1 && !hasFirstPreference)
                    {
                        hasFirstPreference = true;
                        isValid = true;
                    }
                    // However, if this votes is a first preference and another
                    // first preference was found, we have two first preferences
                    // and an invalid vote.
                    else if (entry.Value == 1 && hasFirstPreference)
                    {
                        isValid = false;
                    }
                }
            }

            // if validation method is the sequential: b) votes are declared invalid if they fail to number the candidates sequentially.
            else if (validationMethod == 1)
            {
                // hasFirstPreference is used to record if a first preference has 
                // been found or not. 
                bool hasFirstPreference = false;
                bool hasDuplicates = false;
                bool hasBeyondValue = false;

                IEnumerable<IGrouping<int, string>> lookup = Enumerable.Empty<IGrouping<int, string>>();
                lookup = Votes.ToLookup(x => x.Value, x => x.Key).Where(x => x.Count() > 1);
                foreach (var item in lookup)
                {
                    var keys = item.Aggregate("", (s, v) => s + ", " + v);
                    var message = "The following keys have the value " + item.Key + ":" + keys;
                    Console.WriteLine(message);

                    if (item.Key != -1)
                    {
                        hasDuplicates = true;
                    }
                }

                foreach (KeyValuePair<string, int> entry in Votes)
                {
                    // If this is a first preference, and no other first preference 
                    // has been found, the vote is currently valid
                    if (entry.Value == 1 && !hasFirstPreference && !hasDuplicates && !hasBeyondValue)
                    {
                        hasFirstPreference = true;
                        isValid = true;
                    }
                    // However, if this votes is a first preference and another
                    // first preference was found, we have two first preferences
                    // and an invalid vote.
                    else if (entry.Value == 1 && hasFirstPreference)
                    {
                        isValid = false;
                    }
                    else if (entry.Value > Votes.Count || entry.Value < -1 || entry.Value == 0)
                    {
                        hasBeyondValue = true;
                        isValid = false;
                    }
                }
            }
            else
            {
                Console.WriteLine("Validation failed!");
            }

            // Note that if no first preference was found, the default - that 
            // it is invalid - remains the case.
            return isValid;
        }


        #endregion

        #region Find out who has the first preference for ths voter

        /// <summary>
        /// If the vote is valid, finds the candidate with this voter's
        /// current first preference
        /// </summary>
        /// <returns>Returns the candidate name</returns>
        /// <exception>Thrown if the vote is invalid</exception>
        public String GetFirstPreference(int validationMethod)
        {
            String candidate = "";

            // Check that it is valid, Shouldn't be an issue, as it can be
            // checked independently, but nothing wrong with an overabundance
            // of caution
            if (this.Validate(validationMethod))
            {
                /// Loop through the votes ...
                foreach (KeyValuePair<string, int> vote in Votes)
                {
                    // ... looking for the one with the first preference ...
                    if (vote.Value == 1)
                    {
                        // ... and record their name!
                        candidate = vote.Key;
                    }
                }
            }
            else
            {
                // Throw an exception because it failed validation
                throw new Exception("Vote failed validation");
            }

            return candidate;
        }

        #endregion

        #region Remove a candidate from the ballot

        /// <summary>
        /// Removes the specified candidate from the vote and reasigns
        /// preferences to match.
        /// </summary>
        /// <remarks>
        /// The candidate with the lowest number of votes is removed from the ballot.
        /// In that case, all preferences for the candidate are set to -1, to 
        /// indicate preclusion, and all preferences above the candidate's 
        /// move down one postion. For example if A, B, C & D are running,
        /// and B is preculded, a ballot with preferences 2, 3, 1, 4 (respectively)
        /// becomes 2, -1, 1, 3.
        /// </remarks>
        public void RemoveCandidate(String targetCandidate)
        {
            int targetPreference = this.Votes[targetCandidate];

            // Get list of candidates
            string[] candidates = this.Votes.Keys.ToArray<string>();

            foreach (string candidate in candidates)
            {

                if (Votes[candidate] == targetPreference)
                {
                    Votes[candidate] = -1;
                }
                else if (Votes[candidate] > targetPreference)
                {
                    Votes[candidate] -= 1;
                }
            }
        }

        #endregion
    }
}
