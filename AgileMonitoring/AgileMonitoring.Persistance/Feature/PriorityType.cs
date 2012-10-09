namespace AgileMonitoring.Persistance.Feature
{
    /// <summary>
    /// MoSCoW priorities as level examples
    /// </summary>
    public enum PriorityType : short
    {
        /// <summary>
        /// default level
        /// </summary>
        NONE = 0,

        /// <summary>
        /// nice to have level
        /// </summary>
        WOULD = 1,

        /// <summary>
        /// optional level
        /// </summary>
        COULD = 2,

        /// <summary>
        /// mandatory level
        /// </summary>
        SHOULD = 3,

        /// <summary>
        /// urgent level
        /// </summary>
        MUST = 4,
    }
}