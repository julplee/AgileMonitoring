namespace AgileMonitoring.Persistance.Individual
{
    using System.Data.Entity;

    /// <summary>
    /// Repository of Individuals
    /// </summary>
    class IndividualRepository : DbContext
    {
        public DbSet<Individual> Individuals { get; set; }
    }
}
