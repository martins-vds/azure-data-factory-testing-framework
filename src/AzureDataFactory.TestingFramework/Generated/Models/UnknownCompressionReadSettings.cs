// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace AzureDataFactory.TestingFramework.Models
{
    /// <summary> The UnknownCompressionReadSettings. </summary>
    internal partial class UnknownCompressionReadSettings : CompressionReadSettings
    {
        /// <summary> Initializes a new instance of UnknownCompressionReadSettings. </summary>
        /// <param name="compressionReadSettingsType"> The Compression setting type. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        internal UnknownCompressionReadSettings(string compressionReadSettingsType, IDictionary<string, BinaryData> additionalProperties) : base(compressionReadSettingsType, additionalProperties)
        {
            CompressionReadSettingsType = compressionReadSettingsType ?? "Unknown";
        }
    }
}
