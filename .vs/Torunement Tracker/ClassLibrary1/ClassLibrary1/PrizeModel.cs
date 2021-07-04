using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class PrizeModel
    {
        /// <summary>
        /// Represents the numerical finishing place of
        /// a team
        /// </summary>
        public int PlaceNumber { get; set; }

        /// <summary>
        /// Represents the name of the finishing place of a team
        /// </summary>
        public string PlaceName { get; set; }

        /// <summary>
        /// Represents the prize amount of the winning team
        /// </summary>
        public decimal PrizeAmount { get; set; }

        /// <summary>
        /// represents the percent of the total prize amount 
        /// for the tournament
        /// </summary>
        public double PrizePercentage { get; set; }
    }
}
