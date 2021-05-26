using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    public class MatchupModel
    {
        /// <summary>
        /// Represents the participants of a Matchup
        /// </summary>
        public List<MatchupEntryModel> Entries { get; set; } = new List<MatchupEntryModel>();
        /// <summary>
        /// Represents the Winner of a Matchup
        /// </summary>
        public TeamModel Winner { get; set; }
        /// <summary>
        /// Represents the Round a Matchup is part of
        /// </summary>
        public int MatchupRound { get; set; }
    }
}
