// <auto-generated/>

#nullable disable

using Azure.Core;

namespace AzureDataFactory.TestingFramework.Models
{
    /// <summary> Integration runtime status response. </summary>
    public partial class DataFactoryIntegrationRuntimeStatusResult
    {
        /// <summary> Initializes a new instance of DataFactoryIntegrationRuntimeStatusResult. </summary>
        /// <param name="properties">
        /// Integration runtime properties.
        /// Please note <see cref="IntegrationRuntimeStatus"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="ManagedIntegrationRuntimeStatus"/> and <see cref="SelfHostedIntegrationRuntimeStatus"/>.
        /// </param>
        /// <exception cref="ArgumentNullException"> <paramref name="properties"/> is null. </exception>
        internal DataFactoryIntegrationRuntimeStatusResult(IntegrationRuntimeStatus properties)
        {
            Argument.AssertNotNull(properties, nameof(properties));

            Properties = properties;
        }

        /// <summary> Initializes a new instance of DataFactoryIntegrationRuntimeStatusResult. </summary>
        /// <param name="name"> The integration runtime name. </param>
        /// <param name="properties">
        /// Integration runtime properties.
        /// Please note <see cref="IntegrationRuntimeStatus"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="ManagedIntegrationRuntimeStatus"/> and <see cref="SelfHostedIntegrationRuntimeStatus"/>.
        /// </param>
        internal DataFactoryIntegrationRuntimeStatusResult(string name, IntegrationRuntimeStatus properties)
        {
            Name = name;
            Properties = properties;
        }

        /// <summary> The integration runtime name. </summary>
        public string Name { get; }
        /// <summary>
        /// Integration runtime properties.
        /// Please note <see cref="IntegrationRuntimeStatus"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="ManagedIntegrationRuntimeStatus"/> and <see cref="SelfHostedIntegrationRuntimeStatus"/>.
        /// </summary>
        public IntegrationRuntimeStatus Properties { get; }
    }
}
