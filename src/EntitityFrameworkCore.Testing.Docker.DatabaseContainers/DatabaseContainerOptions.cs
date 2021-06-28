using System;

namespace EntitityFrameworkCore.Testing.Docker.DatabaseContainers
{
    /// <summary>
    /// Defines the options/settings for the Database Container.
    /// </summary>
    public class DatabaseContainerOptions
    {
        /// <summary>
        /// Gets or inits the Database Container Name.
        /// </summary>
        public string DatabaseContainerImage { get; init; }

        /// <summary>
        /// Gets or inits the Database Container Port.
        /// </summary>
        public int? DatabseContainerPort { get; init; }
    }
}
