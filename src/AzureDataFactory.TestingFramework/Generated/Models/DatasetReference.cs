// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;

namespace AzureDataFactory.TestingFramework.Models
{
    /// <summary> Dataset reference type. </summary>
    public partial class DatasetReference
    {
        /// <summary> Initializes a new instance of DatasetReference. </summary>
        /// <param name="referenceType"> Dataset reference type. </param>
        /// <param name="referenceName"> Reference dataset name. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="referenceName"/> is null. </exception>
        public DatasetReference(DatasetReferenceType referenceType, string referenceName)
        {
            Argument.AssertNotNull(referenceName, nameof(referenceName));

            ReferenceType = referenceType;
            ReferenceName = referenceName;
            Parameters = new ChangeTrackingDictionary<string, BinaryData>();
        }

        /// <summary> Initializes a new instance of DatasetReference. </summary>
        /// <param name="referenceType"> Dataset reference type. </param>
        /// <param name="referenceName"> Reference dataset name. </param>
        /// <param name="parameters"> Arguments for dataset. </param>
        internal DatasetReference(DatasetReferenceType referenceType, string referenceName, IDictionary<string, BinaryData> parameters)
        {
            ReferenceType = referenceType;
            ReferenceName = referenceName;
            Parameters = parameters;
        }

        /// <summary> Dataset reference type. </summary>
        public DatasetReferenceType ReferenceType { get; set; }
        /// <summary> Reference dataset name. </summary>
        public string ReferenceName { get; set; }
        /// <summary>
        /// Arguments for dataset.
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
        public IDictionary<string, BinaryData> Parameters { get; }
    }
}
