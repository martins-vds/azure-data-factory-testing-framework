// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.Core.Expressions.DataFactory;

namespace AzureDataFactory.TestingFramework.Models
{
    /// <summary> HDInsight Pig activity type. </summary>
    public partial class HDInsightPigActivity : ExecutionActivity
    {
        /// <summary> Initializes a new instance of HDInsightPigActivity. </summary>
        /// <param name="name"> Activity name. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public HDInsightPigActivity(string name) : base(name)
        {
            Argument.AssertNotNull(name, nameof(name));

            StorageLinkedServices = new ChangeTrackingList<DataFactoryLinkedServiceReference>();
            Defines = new ChangeTrackingDictionary<string, DataFactoryElement<string>>();
            ActivityType = "HDInsightPig";
        }

        /// <summary> Initializes a new instance of HDInsightPigActivity. </summary>
        /// <param name="name"> Activity name. </param>
        /// <param name="activityType"> Type of activity. </param>
        /// <param name="description"> Activity description. </param>
        /// <param name="state"> Activity state. This is an optional property and if not provided, the state will be Active by default. </param>
        /// <param name="onInactiveMarkAs"> Status result of the activity when the state is set to Inactive. This is an optional property and if not provided when the activity is inactive, the status will be Succeeded by default. </param>
        /// <param name="dependsOn"> Activity depends on condition. </param>
        /// <param name="userProperties"> Activity user properties. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="linkedServiceName"> Linked service reference. </param>
        /// <param name="policy"> Activity policy. </param>
        /// <param name="storageLinkedServices"> Storage linked service references. </param>
        /// <param name="arguments"> User specified arguments to HDInsightActivity. Type: array (or Expression with resultType array). </param>
        /// <param name="getDebugInfo"> Debug info option. </param>
        /// <param name="scriptPath"> Script path. Type: string (or Expression with resultType string). </param>
        /// <param name="scriptLinkedService"> Script linked service reference. </param>
        /// <param name="defines"> Allows user to specify defines for Pig job request. </param>
        internal HDInsightPigActivity(string name, string activityType, string description, PipelineActivityState? state, ActivityOnInactiveMarkAs? onInactiveMarkAs, IList<PipelineActivityDependency> dependsOn, IList<PipelineActivityUserProperty> userProperties, IDictionary<string, DataFactoryElement<string>> additionalProperties, DataFactoryLinkedServiceReference linkedServiceName, PipelineActivityPolicy policy, IList<DataFactoryLinkedServiceReference> storageLinkedServices, BinaryData arguments, HDInsightActivityDebugInfoOptionSetting? getDebugInfo, DataFactoryElement<string> scriptPath, DataFactoryLinkedServiceReference scriptLinkedService, IDictionary<string, DataFactoryElement<string>> defines) : base(name, activityType, description, state, onInactiveMarkAs, dependsOn, userProperties, additionalProperties, linkedServiceName, policy)
        {
            StorageLinkedServices = storageLinkedServices;
            Arguments = arguments;
            GetDebugInfo = getDebugInfo;
            ScriptPath = scriptPath;
            ScriptLinkedService = scriptLinkedService;
            Defines = defines;
            ActivityType = activityType ?? "HDInsightPig";
        }

        /// <summary> Storage linked service references. </summary>
        public IList<DataFactoryLinkedServiceReference> StorageLinkedServices { get; }
        /// <summary>
        /// User specified arguments to HDInsightActivity. Type: array (or Expression with resultType array).
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
        public BinaryData Arguments { get; set; }
        /// <summary> Debug info option. </summary>
        public HDInsightActivityDebugInfoOptionSetting? GetDebugInfo { get; set; }
        /// <summary> Script path. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> ScriptPath { get; set; }
        /// <summary> Script linked service reference. </summary>
        public DataFactoryLinkedServiceReference ScriptLinkedService { get; set; }
        /// <summary>
        /// Allows user to specify defines for Pig job request.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
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
        public IDictionary<string, DataFactoryElement<string>> Defines { get; }
    }
}