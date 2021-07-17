namespace EntitityFrameworkCore.Testing.Docker.DatabaseContainers
{
    /// <summary>
    /// Defines the options/settings for the Container Environment Variable.
    /// </summary>
    public class EnvironmentVariableOptions
    {
        /// <summary>
        /// Gets or inits the Containar's Environment Variable's Name
        /// </summary>
        public string Name { get; init; }

        /// <summary>
        /// Gets or inits the Containar's Environment Variable's Value
        /// </summary>
        public string Value { get; init; }
    }
}
