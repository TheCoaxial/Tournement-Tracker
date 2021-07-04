using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class TeamModel
    {
        /// <summary>
        /// A list of all the persons on a team
        /// </summary>
        public List<PersonModel> TeamMembers { get; set; } = new List<PersonModel>();

        /// <summary>
        /// The name of the team
        /// </summary>
        public string TeamName { get; set; }
    }
}
