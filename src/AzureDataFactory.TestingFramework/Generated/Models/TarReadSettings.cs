// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core.Expressions.DataFactory;

namespace AzureDataFactory.TestingFramework.Models
{
    /// <summary> The Tar compression read settings. </summary>
    public partial class TarReadSettings : CompressionReadSettings
    {
        /// <summary> Initializes a new instance of TarReadSettings. </summary>
        public TarReadSettings()
        {
            CompressionReadSettingsType = "TarReadSettings";
        }

        /// <summary> Initializes a new instance of TarReadSettings. </summary>
        /// <param name="compressionReadSettingsType"> The Compression setting type. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="preserveCompressionFileNameAsFolder"> Preserve the compression file name as folder path. Type: boolean (or Expression with resultType boolean). </param>
        internal TarReadSettings(string compressionReadSettingsType, IDictionary<string, BinaryData> additionalProperties, DataFactoryElement<bool> preserveCompressionFileNameAsFolder) : base(compressionReadSettingsType, additionalProperties)
        {
            PreserveCompressionFileNameAsFolder = preserveCompressionFileNameAsFolder;
            CompressionReadSettingsType = compressionReadSettingsType ?? "TarReadSettings";
        }

        /// <summary> Preserve the compression file name as folder path. Type: boolean (or Expression with resultType boolean). </summary>
        public DataFactoryElement<bool> PreserveCompressionFileNameAsFolder { get; set; }
    }
}
