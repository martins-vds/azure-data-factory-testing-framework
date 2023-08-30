// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace AzureDataFactory.TestingFramework.Models
{
    /// <summary> Json write settings. </summary>
    public partial class JsonWriteSettings : FormatWriteSettings
    {
        /// <summary> Initializes a new instance of JsonWriteSettings. </summary>
        public JsonWriteSettings()
        {
            FormatWriteSettingsType = "JsonWriteSettings";
        }

        /// <summary> Initializes a new instance of JsonWriteSettings. </summary>
        /// <param name="formatWriteSettingsType"> The write setting type. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="filePattern"> File pattern of JSON. This setting controls the way a collection of JSON objects will be treated. The default value is 'setOfObjects'. It is case-sensitive. </param>
        internal JsonWriteSettings(string formatWriteSettingsType, IDictionary<string, BinaryData> additionalProperties, BinaryData filePattern) : base(formatWriteSettingsType, additionalProperties)
        {
            FilePattern = filePattern;
            FormatWriteSettingsType = formatWriteSettingsType ?? "JsonWriteSettings";
        }

        /// <summary>
        /// File pattern of JSON. This setting controls the way a collection of JSON objects will be treated. The default value is 'setOfObjects'. It is case-sensitive.
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
        public BinaryData FilePattern { get; set; }
    }
}
