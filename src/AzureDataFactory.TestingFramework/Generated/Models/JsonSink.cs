// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core.Expressions.DataFactory;

namespace AzureDataFactory.TestingFramework.Models
{
    /// <summary> A copy activity Json sink. </summary>
    public partial class JsonSink : CopySink
    {
        /// <summary> Initializes a new instance of JsonSink. </summary>
        public JsonSink()
        {
            CopySinkType = "JsonSink";
        }

        /// <summary> Initializes a new instance of JsonSink. </summary>
        /// <param name="copySinkType"> Copy sink type. </param>
        /// <param name="writeBatchSize"> Write batch size. Type: integer (or Expression with resultType integer), minimum: 0. </param>
        /// <param name="writeBatchTimeout"> Write batch timeout. Type: string (or Expression with resultType string), pattern: ((\d+)\.)?(\d\d):(60|([0-5][0-9])):(60|([0-5][0-9])). </param>
        /// <param name="sinkRetryCount"> Sink retry count. Type: integer (or Expression with resultType integer). </param>
        /// <param name="sinkRetryWait"> Sink retry wait. Type: string (or Expression with resultType string), pattern: ((\d+)\.)?(\d\d):(60|([0-5][0-9])):(60|([0-5][0-9])). </param>
        /// <param name="maxConcurrentConnections"> The maximum concurrent connection count for the sink data store. Type: integer (or Expression with resultType integer). </param>
        /// <param name="disableMetricsCollection"> If true, disable data store metrics collection. Default is false. Type: boolean (or Expression with resultType boolean). </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="storeSettings">
        /// Json store settings.
        /// Please note <see cref="StoreWriteSettings"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AzureBlobFSWriteSettings"/>, <see cref="AzureBlobStorageWriteSettings"/>, <see cref="AzureDataLakeStoreWriteSettings"/>, <see cref="AzureFileStorageWriteSettings"/>, <see cref="FileServerWriteSettings"/> and <see cref="SftpWriteSettings"/>.
        /// </param>
        /// <param name="formatSettings"> Json format settings. </param>
        internal JsonSink(string copySinkType, DataFactoryElement<int> writeBatchSize, DataFactoryElement<string> writeBatchTimeout, DataFactoryElement<int> sinkRetryCount, DataFactoryElement<string> sinkRetryWait, DataFactoryElement<int> maxConcurrentConnections, DataFactoryElement<bool> disableMetricsCollection, IDictionary<string, DataFactoryElement<string>> additionalProperties, StoreWriteSettings storeSettings, JsonWriteSettings formatSettings) : base(copySinkType, writeBatchSize, writeBatchTimeout, sinkRetryCount, sinkRetryWait, maxConcurrentConnections, disableMetricsCollection, additionalProperties)
        {
            StoreSettings = storeSettings;
            FormatSettings = formatSettings;
            CopySinkType = copySinkType ?? "JsonSink";
        }

        /// <summary>
        /// Json store settings.
        /// Please note <see cref="StoreWriteSettings"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AzureBlobFSWriteSettings"/>, <see cref="AzureBlobStorageWriteSettings"/>, <see cref="AzureDataLakeStoreWriteSettings"/>, <see cref="AzureFileStorageWriteSettings"/>, <see cref="FileServerWriteSettings"/> and <see cref="SftpWriteSettings"/>.
        /// </summary>
        public StoreWriteSettings StoreSettings { get; set; }
        /// <summary> Json format settings. </summary>
        public JsonWriteSettings FormatSettings { get; set; }
    }
}
