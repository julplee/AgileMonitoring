namespace AgileMonitoring.DomainModel.Feature
{
    /// <summary>
    /// MoSCoW priorities
    /// </summary>
    public enum PriorityType : short
    {
        /// <summary>
        /// default level
        /// </summary>
        NONE = 0,

        /// <summary>
        /// urgent level
        /// </summary>
        MUST = 4,

        /// <summary>
        /// mandatory level
        /// </summary>
        SHOULD = 3,

        /// <summary>
        /// optional level
        /// </summary>
        COULD = 2,

        /// <summary>
        /// nice to have level
        /// </summary>
        WOULD = 1,
    }
}