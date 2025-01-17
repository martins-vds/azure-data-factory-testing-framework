// <auto-generated/>

#nullable disable

using Azure.Core.Expressions.DataFactory;

namespace AzureDataFactory.TestingFramework.Models
{
    /// <summary> The UnknownStoreWriteSettings. </summary>
    internal partial class UnknownStoreWriteSettings : StoreWriteSettings
    {
        /// <summary> Initializes a new instance of UnknownStoreWriteSettings. </summary>
        /// <param name="storeWriteSettingsType"> The write setting type. </param>
        /// <param name="maxConcurrentConnections"> The maximum concurrent connection count for the source data store. Type: integer (or Expression with resultType integer). </param>
        /// <param name="disableMetricsCollection"> If true, disable data store metrics collection. Default is false. Type: boolean (or Expression with resultType boolean). </param>
        /// <param name="copyBehavior"> The type of copy behavior for copy sink. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        internal UnknownStoreWriteSettings(string storeWriteSettingsType, DataFactoryElement<int> maxConcurrentConnections, DataFactoryElement<bool> disableMetricsCollection, BinaryData copyBehavior, IDictionary<string, DataFactoryElement<string>> additionalProperties) : base(storeWriteSettingsType, maxConcurrentConnections, disableMetricsCollection, copyBehavior, additionalProperties)
        {
            StoreWriteSettingsType = storeWriteSettingsType ?? "Unknown";
        }
    }
}
