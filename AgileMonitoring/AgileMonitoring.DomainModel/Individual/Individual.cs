using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AgileMonitoring.DomainModel.Individual
{
    /// <summary>
    /// 
    /// </summary>
    class Individual
    {
        /// <summary>
        /// The individual id
        /// </summary>
        public long IndividualId;
       
        /// <summary>
        /// Gets or sets the first name.
        /// </summary>
        /// <value>
        /// The first name.
        /// </value>
        public String FirstName { get; set; }

        /// <summary>
        /// Gets or sets the last name.
        /// </summary>
        /// <value>
        /// The last name.
        /// </value>
        public String LastName { get; set; }

        /// <summary>
        /// Gets or sets the name of the user.
        /// </summary>
        /// <value>
        /// The name of the user.
        /// </value>
        public String UserName { get; set; }



    }
}
