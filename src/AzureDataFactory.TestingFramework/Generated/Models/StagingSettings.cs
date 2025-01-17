// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.Core.Expressions.DataFactory;

namespace AzureDataFactory.TestingFramework.Models
{
    /// <summary> Staging settings. </summary>
    public partial class StagingSettings
    {
        /// <summary> Initializes a new instance of StagingSettings. </summary>
        /// <param name="linkedServiceName"> Staging linked service reference. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="linkedServiceName"/> is null. </exception>
        public StagingSettings(DataFactoryLinkedServiceReference linkedServiceName)
        {
            Argument.AssertNotNull(linkedServiceName, nameof(linkedServiceName));

            LinkedServiceName = linkedServiceName;
            AdditionalProperties = new ChangeTrackingDictionary<string, DataFactoryElement<string>>();
        }

        /// <summary> Initializes a new instance of StagingSettings. </summary>
        /// <param name="linkedServiceName"> Staging linked service reference. </param>
        /// <param name="path"> The path to storage for storing the interim data. Type: string (or Expression with resultType string). </param>
        /// <param name="enableCompression"> Specifies whether to use compression when copying data via an interim staging. Default value is false. Type: boolean (or Expression with resultType boolean). </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        internal StagingSettings(DataFactoryLinkedServiceReference linkedServiceName, DataFactoryElement<string> path, DataFactoryElement<bool> enableCompression, IDictionary<string, DataFactoryElement<string>> additionalProperties)
        {
            LinkedServiceName = linkedServiceName;
            Path = path;
            EnableCompression = enableCompression;
            AdditionalProperties = additionalProperties;
        }

        /// <summary> Staging linked service reference. </summary>
        public DataFactoryLinkedServiceReference LinkedServiceName { get; set; }
        /// <summary> The path to storage for storing the interim data. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> Path { get; set; }
        /// <summary> Specifies whether to use compression when copying data via an interim staging. Default value is false. Type: boolean (or Expression with resultType boolean). </summary>
        public DataFactoryElement<bool> EnableCompression { get; set; }
        /// <summary>
        /// Additional Properties
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
        public IDictionary<string, DataFactoryElement<string>> AdditionalProperties { get; }
    }
}
