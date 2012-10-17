namespace AgileMonitoring.Persistance.Task
{
    #region

    using System.Data.Entity;

    #endregion

    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    public class TaskRepository : DbContext
    {
        /// <summary>
        /// Gets or sets Tasks.
        /// </summary>
        public DbSet<Task> Tasks
        {
            get;
            set;
        }
    }
}