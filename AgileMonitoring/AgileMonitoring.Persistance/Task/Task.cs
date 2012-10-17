namespace AgileMonitoring.Persistance.Task
{
    using AgileMonitoring.Persistance.Feature;
    using AgileMonitoring.Persistance.Individual;

    /// <summary>
    /// A step to be done in a user story.
    /// </summary>
    public class Task
    {
        #region Public Properties

        /// <summary>
        /// Gets or sets the user this task.
        /// </summary>
        public Individual Owner
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the user story containing this task.
        /// </summary>
        public UserStory ParentUserStory
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the task preceding this one.
        /// </summary>
        public Task PreviousTask
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

        #endregion
    }
}