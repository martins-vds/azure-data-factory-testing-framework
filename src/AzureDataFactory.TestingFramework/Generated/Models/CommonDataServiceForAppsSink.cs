// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core.Expressions.DataFactory;

namespace AzureDataFactory.TestingFramework.Models
{
    /// <summary> A copy activity Common Data Service for Apps sink. </summary>
    public partial class CommonDataServiceForAppsSink : CopySink
    {
        /// <summary> Initializes a new instance of CommonDataServiceForAppsSink. </summary>
        /// <param name="writeBehavior"> The write behavior for the operation. </param>
        public CommonDataServiceForAppsSink(DynamicsSinkWriteBehavior writeBehavior)
        {
            WriteBehavior = writeBehavior;
            CopySinkType = "CommonDataServiceForAppsSink";
        }

        /// <summary> Initializes a new instance of CommonDataServiceForAppsSink. </summary>
        /// <param name="copySinkType"> Copy sink type. </param>
        /// <param name="writeBatchSize"> Write batch size. Type: integer (or Expression with resultType integer), minimum: 0. </param>
        /// <param name="writeBatchTimeout"> Write batch timeout. Type: string (or Expression with resultType string), pattern: ((\d+)\.)?(\d\d):(60|([0-5][0-9])):(60|([0-5][0-9])). </param>
        /// <param name="sinkRetryCount"> Sink retry count. Type: integer (or Expression with resultType integer). </param>
        /// <param name="sinkRetryWait"> Sink retry wait. Type: string (or Expression with resultType string), pattern: ((\d+)\.)?(\d\d):(60|([0-5][0-9])):(60|([0-5][0-9])). </param>
        /// <param name="maxConcurrentConnections"> The maximum concurrent connection count for the sink data store. Type: integer (or Expression with resultType integer). </param>
        /// <param name="disableMetricsCollection"> If true, disable data store metrics collection. Default is false. Type: boolean (or Expression with resultType boolean). </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="writeBehavior"> The write behavior for the operation. </param>
        /// <param name="ignoreNullValues"> The flag indicating whether to ignore null values from input dataset (except key fields) during write operation. Default is false. Type: boolean (or Expression with resultType boolean). </param>
        /// <param name="alternateKeyName"> The logical name of the alternate key which will be used when upserting records. Type: string (or Expression with resultType string). </param>
        internal CommonDataServiceForAppsSink(string copySinkType, DataFactoryElement<int> writeBatchSize, DataFactoryElement<string> writeBatchTimeout, DataFactoryElement<int> sinkRetryCount, DataFactoryElement<string> sinkRetryWait, DataFactoryElement<int> maxConcurrentConnections, DataFactoryElement<bool> disableMetricsCollection, IDictionary<string, BinaryData> additionalProperties, DynamicsSinkWriteBehavior writeBehavior, DataFactoryElement<bool> ignoreNullValues, DataFactoryElement<string> alternateKeyName) : base(copySinkType, writeBatchSize, writeBatchTimeout, sinkRetryCount, sinkRetryWait, maxConcurrentConnections, disableMetricsCollection, additionalProperties)
        {
            WriteBehavior = writeBehavior;
            IgnoreNullValues = ignoreNullValues;
            AlternateKeyName = alternateKeyName;
            CopySinkType = copySinkType ?? "CommonDataServiceForAppsSink";
        }

        /// <summary> The write behavior for the operation. </summary>
        public DynamicsSinkWriteBehavior WriteBehavior { get; set; }
        /// <summary> The flag indicating whether to ignore null values from input dataset (except key fields) during write operation. Default is false. Type: boolean (or Expression with resultType boolean). </summary>
        public DataFactoryElement<bool> IgnoreNullValues { get; set; }
        /// <summary> The logical name of the alternate key which will be used when upserting records. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> AlternateKeyName { get; set; }
    }
}
