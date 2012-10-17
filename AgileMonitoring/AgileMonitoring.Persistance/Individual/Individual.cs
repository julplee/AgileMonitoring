namespace AgileMonitoring.Persistance.Individual
{
    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    public class Individual
    {
        #region Public Properties

        /// <summary>
        /// Gets or sets the first name.
        /// </summary>
        /// <value>
        /// The first name. 
        /// </value>
        public string FirstName
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the individual identifier.
        /// </summary>
        /// <value>
        /// The individual identifier.
        /// </value>
        public long IndividualId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the last name.
        /// </summary>
        /// <value>
        /// The last name. 
        /// </value>
        public string LastName
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the name of the user.
        /// </summary>
        /// <value>
        /// The name of the user. 
        /// </value>
        public string UserName
        {
            get;
            set;
        }

        #endregion
    }
}