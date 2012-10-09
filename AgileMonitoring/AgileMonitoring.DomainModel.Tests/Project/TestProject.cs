namespace AgileMonitoring.DomainModel.Tests.Project
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using NUnit.Framework;
    using AgileMonitoring.DomainModel.Project;

    [TestFixture]
    public class TestProject
    {
        [Test]
        [ExpectedException(typeof(InvalidOperationException))]
        public void Project_SetEndDateAnteriorToBeginDate_ThrowsInvalidOperationException()
        {
            var date = DateTime.Now;

            Project project = new Project("Test Project");
            project.BeginDate = date;
            project.EndDate = date.AddDays(-1);
        }
    }
}
