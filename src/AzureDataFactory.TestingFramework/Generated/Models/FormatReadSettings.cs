// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.Core.Expressions.DataFactory;

namespace AzureDataFactory.TestingFramework.Models
{
    /// <summary>
    /// Format read settings.
    /// Please note <see cref="FormatReadSettings"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="BinaryReadSettings"/>, <see cref="JsonReadSettings"/>, <see cref="XmlReadSettings"/> and <see cref="DelimitedTextReadSettings"/>.
    /// </summary>
    public partial class FormatReadSettings
    {
        /// <summary> Initializes a new instance of FormatReadSettings. </summary>
        public FormatReadSettings()
        {
            AdditionalProperties = new ChangeTrackingDictionary<string, DataFactoryElement<string>>();
        }

        /// <summary> Initializes a new instance of FormatReadSettings. </summary>
        /// <param name="formatReadSettingsType"> The read setting type. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        internal FormatReadSettings(string formatReadSettingsType, IDictionary<string, DataFactoryElement<string>> additionalProperties)
        {
            FormatReadSettingsType = formatReadSettingsType;
            AdditionalProperties = additionalProperties;
        }

        /// <summary> The read setting type. </summary>
        internal string FormatReadSettingsType { get; set; }
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
