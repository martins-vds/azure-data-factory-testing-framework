// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core.Expressions.DataFactory;

namespace AzureDataFactory.TestingFramework.Models
{
    /// <summary> A copy activity SQL Data Warehouse sink. </summary>
    public partial class SqlDWSink : CopySink
    {
        /// <summary> Initializes a new instance of SqlDWSink. </summary>
        public SqlDWSink()
        {
            CopySinkType = "SqlDWSink";
        }

        /// <summary> Initializes a new instance of SqlDWSink. </summary>
        /// <param name="copySinkType"> Copy sink type. </param>
        /// <param name="writeBatchSize"> Write batch size. Type: integer (or Expression with resultType integer), minimum: 0. </param>
        /// <param name="writeBatchTimeout"> Write batch timeout. Type: string (or Expression with resultType string), pattern: ((\d+)\.)?(\d\d):(60|([0-5][0-9])):(60|([0-5][0-9])). </param>
        /// <param name="sinkRetryCount"> Sink retry count. Type: integer (or Expression with resultType integer). </param>
        /// <param name="sinkRetryWait"> Sink retry wait. Type: string (or Expression with resultType string), pattern: ((\d+)\.)?(\d\d):(60|([0-5][0-9])):(60|([0-5][0-9])). </param>
        /// <param name="maxConcurrentConnections"> The maximum concurrent connection count for the sink data store. Type: integer (or Expression with resultType integer). </param>
        /// <param name="disableMetricsCollection"> If true, disable data store metrics collection. Default is false. Type: boolean (or Expression with resultType boolean). </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="preCopyScript"> SQL pre-copy script. Type: string (or Expression with resultType string). </param>
        /// <param name="allowPolyBase"> Indicates to use PolyBase to copy data into SQL Data Warehouse when applicable. Type: boolean (or Expression with resultType boolean). </param>
        /// <param name="polyBaseSettings"> Specifies PolyBase-related settings when allowPolyBase is true. </param>
        /// <param name="allowCopyCommand"> Indicates to use Copy Command to copy data into SQL Data Warehouse. Type: boolean (or Expression with resultType boolean). </param>
        /// <param name="copyCommandSettings"> Specifies Copy Command related settings when allowCopyCommand is true. </param>
        /// <param name="tableOption"> The option to handle sink table, such as autoCreate. For now only 'autoCreate' value is supported. Type: string (or Expression with resultType string). </param>
        /// <param name="sqlWriterUseTableLock"> Whether to use table lock during bulk copy. Type: boolean (or Expression with resultType boolean). </param>
        /// <param name="writeBehavior"> Write behavior when copying data into azure SQL DW. Type: SqlDWWriteBehaviorEnum (or Expression with resultType SqlDWWriteBehaviorEnum). </param>
        /// <param name="upsertSettings"> SQL DW upsert settings. </param>
        internal SqlDWSink(string copySinkType, DataFactoryElement<int> writeBatchSize, DataFactoryElement<string> writeBatchTimeout, DataFactoryElement<int> sinkRetryCount, DataFactoryElement<string> sinkRetryWait, DataFactoryElement<int> maxConcurrentConnections, DataFactoryElement<bool> disableMetricsCollection, IDictionary<string, BinaryData> additionalProperties, DataFactoryElement<string> preCopyScript, DataFactoryElement<bool> allowPolyBase, PolybaseSettings polyBaseSettings, DataFactoryElement<bool> allowCopyCommand, DWCopyCommandSettings copyCommandSettings, DataFactoryElement<string> tableOption, DataFactoryElement<bool> sqlWriterUseTableLock, BinaryData writeBehavior, SqlDWUpsertSettings upsertSettings) : base(copySinkType, writeBatchSize, writeBatchTimeout, sinkRetryCount, sinkRetryWait, maxConcurrentConnections, disableMetricsCollection, additionalProperties)
        {
            PreCopyScript = preCopyScript;
            AllowPolyBase = allowPolyBase;
            PolyBaseSettings = polyBaseSettings;
            AllowCopyCommand = allowCopyCommand;
            CopyCommandSettings = copyCommandSettings;
            TableOption = tableOption;
            SqlWriterUseTableLock = sqlWriterUseTableLock;
            WriteBehavior = writeBehavior;
            UpsertSettings = upsertSettings;
            CopySinkType = copySinkType ?? "SqlDWSink";
        }

        /// <summary> SQL pre-copy script. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> PreCopyScript { get; set; }
        /// <summary> Indicates to use PolyBase to copy data into SQL Data Warehouse when applicable. Type: boolean (or Expression with resultType boolean). </summary>
        public DataFactoryElement<bool> AllowPolyBase { get; set; }
        /// <summary> Specifies PolyBase-related settings when allowPolyBase is true. </summary>
        public PolybaseSettings PolyBaseSettings { get; set; }
        /// <summary> Indicates to use Copy Command to copy data into SQL Data Warehouse. Type: boolean (or Expression with resultType boolean). </summary>
        public DataFactoryElement<bool> AllowCopyCommand { get; set; }
        /// <summary> Specifies Copy Command related settings when allowCopyCommand is true. </summary>
        public DWCopyCommandSettings CopyCommandSettings { get; set; }
        /// <summary> The option to handle sink table, such as autoCreate. For now only 'autoCreate' value is supported. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> TableOption { get; set; }
        /// <summary> Whether to use table lock during bulk copy. Type: boolean (or Expression with resultType boolean). </summary>
        public DataFactoryElement<bool> SqlWriterUseTableLock { get; set; }
        /// <summary>
        /// Write behavior when copying data into azure SQL DW. Type: SqlDWWriteBehaviorEnum (or Expression with resultType SqlDWWriteBehaviorEnum)
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
        public BinaryData WriteBehavior { get; set; }
        /// <summary> SQL DW upsert settings. </summary>
        public SqlDWUpsertSettings UpsertSettings { get; set; }
    }
}
