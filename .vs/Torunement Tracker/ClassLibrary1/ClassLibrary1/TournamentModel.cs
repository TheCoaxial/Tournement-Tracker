using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    class TournamentModel
    {
        /// <summary>
        /// Represents the name of the tournament
        /// </summary>
        public string TournamentName { get; set; }

        /// <summary>
        /// represents the amount of money paid as an entry fee
        /// </summary>
        public decimal EntryFee { get; set; }

        /// <summary>
        /// A list of all the teams entered in the tournament
        /// </summary>
        public List<TeamModel> EnteredTeams { get; set; } = new List<TeamModel>();

        /// <summary>
        /// A list of the prizes for top placing teams
        /// </summary>
        public List<PrizeModel> Prizes { get; set; } = new List<PrizeModel>();

        /// <summary>
        /// A list of team matchups for the tournament
        /// </summary>
        public List<MatchupModel> Rounds { get; set; } = new List<MatchupModel>();
    }
}
