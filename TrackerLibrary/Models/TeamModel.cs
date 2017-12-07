using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Model
{
    public class TeamModel
    {
        /// <summary>
        /// List of Team Members from the person model
        /// </summary>
        public List<PersonModel> TeamMembers { get; set; } = new List<PersonModel>();

        /// <summary>
        /// String of the TeamName for tournament
        /// </summary>
        public string TeamName { get; set; }
    }
}
