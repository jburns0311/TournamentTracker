using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Model
{
    public class TournamentModel
    {
        /// <summary>
        /// Name selected by the tournament creator
        /// </summary>
        public string TournamentName { get; set; }

        /// <summary>
        /// The cost of joining the tournament
        /// </summary>
        public decimal EntryFee { get; set; }

        /// <summary>
        /// List of entered teams
        /// </summary>
        public List<TeamModel> EnteredTeams { get; set; } = new List<TeamModel>();
        /// <summary>
        /// List of Prizes
        /// </summary>
        public List<PrizeModel> Prizes { get; set; } = new List<PrizeModel>();

        /// <summary>
        /// List of a list of the Matchup Model to state the rounds
        /// </summary>
        public List<List<MatchupModel>> Rounds { get; set; } = new List<List<MatchupModel>>();


    }
}
