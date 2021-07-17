using System;
using System.Collections.Generic;

namespace EntitityFrameworkCore.Testing.Docker.DatabaseContainers
{
    /// <summary>
    /// Defines the options/settings for the Database and Container.
    /// </summary>
    public class DatabaseContainerOptions
    {
        /// <summary>
        /// Gets or inits the Containar's Name
        /// </summary>
        public string Name { get; init; }

        /// <summary>
        /// Gets or inits the Container's Image.
        /// </summary>
        public string Image { get; init; }

        /// <summary>
        /// Gets or inits the Container's Port.
        /// </summary>
        public int? Port { get; init; }

        /// <summary>
        /// Gets or inits the Environment Variable Options.
        /// </summary>
        public IEnumerable<EnvironmentVariableOptions> EnvironmentVariableOptions { get; init; }
    }
}
