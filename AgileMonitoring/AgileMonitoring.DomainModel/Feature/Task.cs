namespace AgileMonitoring.DomainModel.Feature
{
    /// <summary>
    /// A step to be done in a user story.
    /// </summary>
    public class Task
    {
        #region Public Properties

        /// <summary>
        /// Gets or sets the task preceding this one.
        /// </summary>
        public Task PreviousTask
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the content of the task.
        /// </summary>
        public string TaskContent
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets Task identifier.
        /// </summary>
        public int TaskId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the user story owning this task.
        /// </summary>
        public UserStory TaskOwner
        {
            get;
            set;
        }

        #endregion
    }
}