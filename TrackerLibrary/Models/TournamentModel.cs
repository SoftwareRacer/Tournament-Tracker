using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    public class TournamentModel
    {
        /// <summary>
        /// Represents the name of a Tournament
        /// </summary>
        public string TournamentName { get; set; }
        /// <summary>
        /// Represents the Entry Fee which is to pay for 
        /// Tournament participation
        /// </summary>
        public decimal EntryFee { get; set; }
        /// <summary>
        /// Represents the List of participating teams
        /// </summary>
        public List<TeamModel> EnteredTeams { get; set; }
        /// <summary>
        /// Represents the prizes for reaching certain places
        /// </summary>
        public List<PrizeModel> Prizes { get; set; } = new List<PrizeModel>();
        /// <summary>
        /// Represents the Rounds with all its Matchups
        /// </summary>
        public List<List<MatchupModel>> Rounds { get; set; } = new List<List<MatchupModel>>();
    }
}
