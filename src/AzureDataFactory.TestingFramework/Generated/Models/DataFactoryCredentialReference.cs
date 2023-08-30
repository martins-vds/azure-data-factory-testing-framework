// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;

namespace AzureDataFactory.TestingFramework.Models
{
    /// <summary> Credential reference type. </summary>
    public partial class DataFactoryCredentialReference
    {
        /// <summary> Initializes a new instance of DataFactoryCredentialReference. </summary>
        /// <param name="referenceType"> Credential reference type. </param>
        /// <param name="referenceName"> Reference credential name. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="referenceName"/> is null. </exception>
        public DataFactoryCredentialReference(DataFactoryCredentialReferenceType referenceType, string referenceName)
        {
            Argument.AssertNotNull(referenceName, nameof(referenceName));

            ReferenceType = referenceType;
            ReferenceName = referenceName;
            AdditionalProperties = new ChangeTrackingDictionary<string, BinaryData>();
        }

        /// <summary> Initializes a new instance of DataFactoryCredentialReference. </summary>
        /// <param name="referenceType"> Credential reference type. </param>
        /// <param name="referenceName"> Reference credential name. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        internal DataFactoryCredentialReference(DataFactoryCredentialReferenceType referenceType, string referenceName, IDictionary<string, BinaryData> additionalProperties)
        {
            ReferenceType = referenceType;
            ReferenceName = referenceName;
            AdditionalProperties = additionalProperties;
        }

        /// <summary> Credential reference type. </summary>
        public DataFactoryCredentialReferenceType ReferenceType { get; set; }
        /// <summary> Reference credential name. </summary>
        public string ReferenceName { get; set; }
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
        public IDictionary<string, BinaryData> AdditionalProperties { get; }
    }
}
