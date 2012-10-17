using AgileMonitoring.Persistance.Feature;

namespace AgileMonitoring.Persistance.UserStory
{
    #region

    using System;
    using System.Collections.Generic;
    using Task;
    using Individual;

    #endregion

    /// <summary>
    /// Basic description of a user story.
    /// </summary>
    public class UserStory
    {
        #region Public Properties

        /// <summary>
        /// Gets or sets user story role part.
        /// </summary>
        public string As
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets user story commentary to provide futher explaination.
        /// </summary>
        public string Comment
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets user story creation date.
        /// </summary>
        public DateTime CreationDate
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets user story priority level.
        /// </summary>
        public PriorityType Priority
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets user story reference.
        /// </summary>
        public string Reference
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets user story benefit part.
        /// </summary>
        public string SoThat
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets user story tasks.
        /// </summary>
        public List<Task> Tasks
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets user story identifier.
        /// </summary>
        public int UserStoryId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets user story goal part.
        /// </summary>
        public string Want
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets user story estimated weight.
        /// </summary>
        public double WeightEstimated
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets user story estimated weight.
        /// </summary>
        public double WeightRealized
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the project for this US.
        /// </summary>
        public Project Project { get; set; }

        /// <summary>
        /// Gets or sets the developpers for this US
        /// </summary>
        public IList<Individual> Developers { get; set; }

        /// <summary>
        /// Gets or sets the state of this US
        /// </summary>
        public State State { get; set; }


        #endregion
    }
}