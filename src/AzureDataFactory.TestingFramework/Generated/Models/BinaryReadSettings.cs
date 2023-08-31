// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core.Expressions.DataFactory;

namespace AzureDataFactory.TestingFramework.Models
{
    /// <summary> Binary read settings. </summary>
    public partial class BinaryReadSettings : FormatReadSettings
    {
        /// <summary> Initializes a new instance of BinaryReadSettings. </summary>
        public BinaryReadSettings()
        {
            FormatReadSettingsType = "BinaryReadSettings";
        }

        /// <summary> Initializes a new instance of BinaryReadSettings. </summary>
        /// <param name="formatReadSettingsType"> The read setting type. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="compressionProperties">
        /// Compression settings.
        /// Please note <see cref="CompressionReadSettings"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="TarGzipReadSettings"/>, <see cref="TarReadSettings"/> and <see cref="ZipDeflateReadSettings"/>.
        /// </param>
        internal BinaryReadSettings(string formatReadSettingsType, IDictionary<string, DataFactoryElement<string>> additionalProperties, CompressionReadSettings compressionProperties) : base(formatReadSettingsType, additionalProperties)
        {
            CompressionProperties = compressionProperties;
            FormatReadSettingsType = formatReadSettingsType ?? "BinaryReadSettings";
        }

        /// <summary>
        /// Compression settings.
        /// Please note <see cref="CompressionReadSettings"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="TarGzipReadSettings"/>, <see cref="TarReadSettings"/> and <see cref="ZipDeflateReadSettings"/>.
        /// </summary>
        public CompressionReadSettings CompressionProperties { get; set; }
    }
}
