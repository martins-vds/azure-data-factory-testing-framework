// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core.Expressions.DataFactory;

namespace AzureDataFactory.TestingFramework.Models
{
    /// <summary> Azure blobFS write settings. </summary>
    public partial class AzureBlobFSWriteSettings : StoreWriteSettings
    {
        /// <summary> Initializes a new instance of AzureBlobFSWriteSettings. </summary>
        public AzureBlobFSWriteSettings()
        {
            StoreWriteSettingsType = "AzureBlobFSWriteSettings";
        }

        /// <summary> Initializes a new instance of AzureBlobFSWriteSettings. </summary>
        /// <param name="storeWriteSettingsType"> The write setting type. </param>
        /// <param name="maxConcurrentConnections"> The maximum concurrent connection count for the source data store. Type: integer (or Expression with resultType integer). </param>
        /// <param name="disableMetricsCollection"> If true, disable data store metrics collection. Default is false. Type: boolean (or Expression with resultType boolean). </param>
        /// <param name="copyBehavior"> The type of copy behavior for copy sink. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="blockSizeInMB"> Indicates the block size(MB) when writing data to blob. Type: integer (or Expression with resultType integer). </param>
        internal AzureBlobFSWriteSettings(string storeWriteSettingsType, DataFactoryElement<int> maxConcurrentConnections, DataFactoryElement<bool> disableMetricsCollection, BinaryData copyBehavior, IDictionary<string, DataFactoryElement<string>> additionalProperties, DataFactoryElement<int> blockSizeInMB) : base(storeWriteSettingsType, maxConcurrentConnections, disableMetricsCollection, copyBehavior, additionalProperties)
        {
            BlockSizeInMB = blockSizeInMB;
            StoreWriteSettingsType = storeWriteSettingsType ?? "AzureBlobFSWriteSettings";
        }

        /// <summary> Indicates the block size(MB) when writing data to blob. Type: integer (or Expression with resultType integer). </summary>
        public DataFactoryElement<int> BlockSizeInMB { get; set; }
    }
}
