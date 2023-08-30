// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core.Expressions.DataFactory;

namespace AzureDataFactory.TestingFramework.Models
{
    /// <summary> A copy activity Azure CosmosDB (SQL API) Collection source. </summary>
    public partial class CosmosDBSqlApiSource : CopyActivitySource
    {
        /// <summary> Initializes a new instance of CosmosDBSqlApiSource. </summary>
        public CosmosDBSqlApiSource()
        {
            CopySourceType = "CosmosDbSqlApiSource";
        }

        /// <summary> Initializes a new instance of CosmosDBSqlApiSource. </summary>
        /// <param name="copySourceType"> Copy source type. </param>
        /// <param name="sourceRetryCount"> Source retry count. Type: integer (or Expression with resultType integer). </param>
        /// <param name="sourceRetryWait"> Source retry wait. Type: string (or Expression with resultType string), pattern: ((\d+)\.)?(\d\d):(60|([0-5][0-9])):(60|([0-5][0-9])). </param>
        /// <param name="maxConcurrentConnections"> The maximum concurrent connection count for the source data store. Type: integer (or Expression with resultType integer). </param>
        /// <param name="disableMetricsCollection"> If true, disable data store metrics collection. Default is false. Type: boolean (or Expression with resultType boolean). </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="query"> SQL API query. Type: string (or Expression with resultType string). </param>
        /// <param name="pageSize"> Page size of the result. Type: integer (or Expression with resultType integer). </param>
        /// <param name="preferredRegions"> Preferred regions. Type: array of strings (or Expression with resultType array of strings). </param>
        /// <param name="detectDatetime"> Whether detect primitive values as datetime values. Type: boolean (or Expression with resultType boolean). </param>
        /// <param name="additionalColumns"> Specifies the additional columns to be added to source data. Type: array of objects(AdditionalColumns) (or Expression with resultType array of objects). </param>
        internal CosmosDBSqlApiSource(string copySourceType, DataFactoryElement<int> sourceRetryCount, DataFactoryElement<string> sourceRetryWait, DataFactoryElement<int> maxConcurrentConnections, DataFactoryElement<bool> disableMetricsCollection, IDictionary<string, BinaryData> additionalProperties, DataFactoryElement<string> query, DataFactoryElement<int> pageSize, DataFactoryElement<IList<string>> preferredRegions, DataFactoryElement<bool> detectDatetime, BinaryData additionalColumns) : base(copySourceType, sourceRetryCount, sourceRetryWait, maxConcurrentConnections, disableMetricsCollection, additionalProperties)
        {
            Query = query;
            PageSize = pageSize;
            PreferredRegions = preferredRegions;
            DetectDatetime = detectDatetime;
            AdditionalColumns = additionalColumns;
            CopySourceType = copySourceType ?? "CosmosDbSqlApiSource";
        }

        /// <summary> SQL API query. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> Query { get; set; }
        /// <summary> Page size of the result. Type: integer (or Expression with resultType integer). </summary>
        public DataFactoryElement<int> PageSize { get; set; }
        /// <summary> Preferred regions. Type: array of strings (or Expression with resultType array of strings). </summary>
        public DataFactoryElement<IList<string>> PreferredRegions { get; set; }
        /// <summary> Whether detect primitive values as datetime values. Type: boolean (or Expression with resultType boolean). </summary>
        public DataFactoryElement<bool> DetectDatetime { get; set; }
        /// <summary>
        /// Specifies the additional columns to be added to source data. Type: array of objects(AdditionalColumns) (or Expression with resultType array of objects).
        /// <para>
        /// To assign an object to this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formated json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        public BinaryData AdditionalColumns { get; set; }
    }
}
