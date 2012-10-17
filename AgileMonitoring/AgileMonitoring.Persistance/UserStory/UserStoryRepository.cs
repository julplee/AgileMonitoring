namespace AgileMonitoring.Persistance.UserStory
{
    #region

    using System.Data.Entity;

    #endregion


    public class UserStoryRepository : DbContext
    {
        /// <summary>
        /// Gets or sets UserStory.
        /// </summary>
        public DbSet<UserStory> UserStories
        {
            get;
            set;
        }
    }
}