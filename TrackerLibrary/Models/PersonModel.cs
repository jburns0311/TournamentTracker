using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Model
{
    public class PersonModel
    {
        /// <summary>
        /// Represents the first name of team memember.
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Last name of a team member
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Submitted Email to be contacted by
        /// </summary>
        public string EmailAddress { get; set; }

        /// <summary>
        /// Cell Phone to be contacted by
        /// </summary>
        public string CellphonNumber { get; set; }
    }
}
