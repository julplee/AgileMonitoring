namespace AgileMonitoring.Persistance.UserStory
{
    /// <summary>
    /// Possibles states of a user story
    /// </summary>
    public enum State : short
    {
        /// <summary>
        /// Created
        /// </summary>
        CREATED = 0,

        /// <summary>
        /// Ready
        /// </summary>
        READY = 1,

        /// <summary>
        /// Assigned
        /// </summary>
        ASSIGNED = 2,

        /// <summary>
        /// In progress
        /// </summary>
        IN_PROGRESS = 3,

        /// <summary>
        /// To validate
        /// </summary>
        TO_VALIDATE = 4,

        /// <summary>
        /// Done
        /// </summary>
        DONE = 5,

        /// <summary>
        /// Validated
        /// </summary>
        VALIDATED = 6,
    }
}