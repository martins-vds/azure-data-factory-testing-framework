// <auto-generated/>

#nullable disable

using Azure.Core.Expressions.DataFactory;

namespace AzureDataFactory.TestingFramework.Models
{
    /// <summary> The UnknownIntegrationRuntime. </summary>
    internal partial class UnknownIntegrationRuntime : DataFactoryIntegrationRuntimeProperties
    {
        /// <summary> Initializes a new instance of UnknownIntegrationRuntime. </summary>
        /// <param name="integrationRuntimeType"> Type of integration runtime. </param>
        /// <param name="description"> Integration runtime description. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        internal UnknownIntegrationRuntime(IntegrationRuntimeType integrationRuntimeType, string description, IDictionary<string, DataFactoryElement<string>> additionalProperties) : base(integrationRuntimeType, description, additionalProperties)
        {
            IntegrationRuntimeType = integrationRuntimeType;
        }
    }
}
