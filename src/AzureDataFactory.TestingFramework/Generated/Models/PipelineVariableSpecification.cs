// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace AzureDataFactory.TestingFramework.Models
{
    /// <summary> Definition of a single variable for a Pipeline. </summary>
    public partial class PipelineVariableSpecification
    {
        /// <summary> Initializes a new instance of PipelineVariableSpecification. </summary>
        /// <param name="variableType"> Variable type. </param>
        public PipelineVariableSpecification(PipelineVariableType variableType)
        {
            VariableType = variableType;
        }

        /// <summary> Initializes a new instance of PipelineVariableSpecification. </summary>
        /// <param name="variableType"> Variable type. </param>
        /// <param name="defaultValue"> Default value of variable. </param>
        internal PipelineVariableSpecification(PipelineVariableType variableType, BinaryData defaultValue)
        {
            VariableType = variableType;
            DefaultValue = defaultValue;
        }

        /// <summary> Variable type. </summary>
        public PipelineVariableType VariableType { get; set; }
        /// <summary>
        /// Default value of variable.
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
        public BinaryData DefaultValue { get; set; }
    }
}
