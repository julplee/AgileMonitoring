namespace AgileMonitoring.Persistance.Feature
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using AgileMonitoring.Persistance.Individual;
    using AgileMonitoring.Persistance.UserStory;

    public class Project
    {

        /// <summary>
        /// Gets or sets the project beginning date
        /// </summary>
        public DateTime BeginDateUtc { get; set; }

        /// <summary>
        /// Gets or sets the project ending date
        /// </summary>
        public DateTime EndDateUtc { get; set; }

        /// <summary>
        /// Gets or sets the initial due date for the project
        /// </summary>
        public DateTime DueDateUtc { get; set; }

        /// <summary>
        /// Gets or sets the name of the project
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the owner of the project
        /// </summary>
        public Individual Owner { get; set; }

        /// <summary>
        /// Gets or sets the list of user stories
        /// </summary>
        public IList<UserStory> UserStories { get; set; }

        /// <summary>
        /// Gets or sets the amount of days for the entire project
        /// </summary>
        public int TotalDays { get; set; }
    }
}
