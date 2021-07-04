using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class MatchupModel
    {
        /// <summary>
        /// Represents the teams entered to compete 
        /// </summary>
        public List<MatchupEntryModel> Entries { get; set; } = new List<MatchupEntryModel>();

        /// <summary>
        /// Represents the team that won the round
        /// </summary>
        public TeamModel Winner { get; set; }

        /// <summary>
        /// represents the round of the current matchup
        /// </summary>
        public int MatchupRound { get; set; }
    }
}
