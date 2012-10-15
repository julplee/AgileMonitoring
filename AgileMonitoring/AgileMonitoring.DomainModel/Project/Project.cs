namespace AgileMonitoring.DomainModel.Project
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    public class Project
    {
        private DateTime _beginDateUtc;

        public Project(string name)
        {
            this.Name = name;
        }

        public DateTime BeginDate
        {
            get { return this._beginDateUtc.ToLocalTime(); }
            set { this._beginDateUtc = value.ToUniversalTime(); }
        }

        public DateTime EndDate
        {
            get
            {
                // TODO calculate this date (consider state)
            }
        }

        public DateTime DueDate { get; set; }

        public string Name { get; set; }

        public Individual Owner { get; set; }

        public IList<UserStory> UserStories { get; set; }

        public int TotalDays { get; set; }

        public int RemainingDays
        {
            get { return NbWorkingDays(BeginDate, DateTime.Now); }
        }

        // TODO JPLEE: qu'est ce ça fout la?
        public static int NbWorkingDays(DateTime startDate, DateTime endDate)
        {
            int nbDays = 0;

            if (endDate <= startDate)
            {
                return 0;
            }

            while (endDate > startDate && endDate.DayOfWeek != DayOfWeek.Sunday &&
                   endDate.DayOfWeek != DayOfWeek.Saturday)
            {
                endDate = endDate.AddDays(-1);
                nbDays++;
            }

            while (startDate < endDate && startDate.DayOfWeek != DayOfWeek.Saturday &&
                   startDate.DayOfWeek != DayOfWeek.Sunday)
            {
                startDate = startDate.AddDays(1);
                nbDays++;
            }

            TimeSpan totalNbDaysSpan = endDate - startDate;

            nbDays += 5*(totalNbDaysSpan.Days/7);
            return nbDays;

        }
    }
}
