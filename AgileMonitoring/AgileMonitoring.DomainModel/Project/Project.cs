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

        private DateTime _endDateUtc;

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
                return _endDateUtc.ToLocalTime();
            }
            set
            {
                var valueUtc = value.ToUniversalTime();

                if (valueUtc < this._beginDateUtc)
                    throw new InvalidOperationException("The end date cannot be anterior to begin date");

                this._endDateUtc = value;
            }
        }

        public string Name { get; set; }
    }
}
