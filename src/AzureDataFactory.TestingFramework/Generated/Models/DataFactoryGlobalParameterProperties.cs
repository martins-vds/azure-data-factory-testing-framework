// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;

namespace AzureDataFactory.TestingFramework.Models
{
    /// <summary> Definition of a single parameter for an entity. </summary>
    public partial class DataFactoryGlobalParameterProperties
    {
        /// <summary> Initializes a new instance of DataFactoryGlobalParameterProperties. </summary>
        /// <param name="globalParameterType"> Global Parameter type. </param>
        /// <param name="value"> Value of parameter. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public DataFactoryGlobalParameterProperties(DataFactoryGlobalParameterType globalParameterType, BinaryData value)
        {
            Argument.AssertNotNull(value, nameof(value));

            GlobalParameterType = globalParameterType;
            Value = value;
        }

        /// <summary> Global Parameter type. </summary>
        public DataFactoryGlobalParameterType GlobalParameterType { get; set; }
        /// <summary>
        /// Value of parameter.
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
        public BinaryData Value { get; set; }
    }
}
