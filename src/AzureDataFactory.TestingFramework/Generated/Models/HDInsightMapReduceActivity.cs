// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.Core.Expressions.DataFactory;

namespace AzureDataFactory.TestingFramework.Models
{
    /// <summary> HDInsight MapReduce activity type. </summary>
    public partial class HDInsightMapReduceActivity : ExecutionActivity
    {
        /// <summary> Initializes a new instance of HDInsightMapReduceActivity. </summary>
        /// <param name="name"> Activity name. </param>
        /// <param name="className"> Class name. Type: string (or Expression with resultType string). </param>
        /// <param name="jarFilePath"> Jar path. Type: string (or Expression with resultType string). </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/>, <paramref name="className"/> or <paramref name="jarFilePath"/> is null. </exception>
        public HDInsightMapReduceActivity(string name, DataFactoryElement<string> className, DataFactoryElement<string> jarFilePath) : base(name)
        {
            Argument.AssertNotNull(name, nameof(name));
            Argument.AssertNotNull(className, nameof(className));
            Argument.AssertNotNull(jarFilePath, nameof(jarFilePath));

            StorageLinkedServices = new ChangeTrackingList<DataFactoryLinkedServiceReference>();
            Arguments = new ChangeTrackingList<BinaryData>();
            ClassName = className;
            JarFilePath = jarFilePath;
            JarLibs = new ChangeTrackingList<BinaryData>();
            Defines = new ChangeTrackingDictionary<string, BinaryData>();
            ActivityType = "HDInsightMapReduce";
        }

        /// <summary> Initializes a new instance of HDInsightMapReduceActivity. </summary>
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
        /// <param name="arguments"> User specified arguments to HDInsightActivity. </param>
        /// <param name="getDebugInfo"> Debug info option. </param>
        /// <param name="className"> Class name. Type: string (or Expression with resultType string). </param>
        /// <param name="jarFilePath"> Jar path. Type: string (or Expression with resultType string). </param>
        /// <param name="jarLinkedService"> Jar linked service reference. </param>
        /// <param name="jarLibs"> Jar libs. </param>
        /// <param name="defines"> Allows user to specify defines for the MapReduce job request. </param>
        internal HDInsightMapReduceActivity(string name, string activityType, string description, PipelineActivityState? state, ActivityOnInactiveMarkAs? onInactiveMarkAs, IList<PipelineActivityDependency> dependsOn, IList<PipelineActivityUserProperty> userProperties, IDictionary<string, BinaryData> additionalProperties, DataFactoryLinkedServiceReference linkedServiceName, PipelineActivityPolicy policy, IList<DataFactoryLinkedServiceReference> storageLinkedServices, IList<BinaryData> arguments, HDInsightActivityDebugInfoOptionSetting? getDebugInfo, DataFactoryElement<string> className, DataFactoryElement<string> jarFilePath, DataFactoryLinkedServiceReference jarLinkedService, IList<BinaryData> jarLibs, IDictionary<string, BinaryData> defines) : base(name, activityType, description, state, onInactiveMarkAs, dependsOn, userProperties, additionalProperties, linkedServiceName, policy)
        {
            StorageLinkedServices = storageLinkedServices;
            Arguments = arguments;
            GetDebugInfo = getDebugInfo;
            ClassName = className;
            JarFilePath = jarFilePath;
            JarLinkedService = jarLinkedService;
            JarLibs = jarLibs;
            Defines = defines;
            ActivityType = activityType ?? "HDInsightMapReduce";
        }

        /// <summary> Storage linked service references. </summary>
        public IList<DataFactoryLinkedServiceReference> StorageLinkedServices { get; }
        /// <summary>
        /// User specified arguments to HDInsightActivity.
        /// <para>
        /// To assign an object to the element of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
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
        public IList<BinaryData> Arguments { get; }
        /// <summary> Debug info option. </summary>
        public HDInsightActivityDebugInfoOptionSetting? GetDebugInfo { get; set; }
        /// <summary> Class name. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> ClassName { get; set; }
        /// <summary> Jar path. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> JarFilePath { get; set; }
        /// <summary> Jar linked service reference. </summary>
        public DataFactoryLinkedServiceReference JarLinkedService { get; set; }
        /// <summary>
        /// Jar libs.
        /// <para>
        /// To assign an object to the element of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
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
        public IList<BinaryData> JarLibs { get; }
        /// <summary>
        /// Allows user to specify defines for the MapReduce job request.
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
        public IDictionary<string, BinaryData> Defines { get; }
    }
}
