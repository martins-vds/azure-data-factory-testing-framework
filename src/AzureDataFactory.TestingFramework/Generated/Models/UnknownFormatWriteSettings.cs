// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace AzureDataFactory.TestingFramework.Models
{
    /// <summary> The UnknownFormatWriteSettings. </summary>
    internal partial class UnknownFormatWriteSettings : FormatWriteSettings
    {
        /// <summary> Initializes a new instance of UnknownFormatWriteSettings. </summary>
        /// <param name="formatWriteSettingsType"> The write setting type. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        internal UnknownFormatWriteSettings(string formatWriteSettingsType, IDictionary<string, BinaryData> additionalProperties) : base(formatWriteSettingsType, additionalProperties)
        {
            FormatWriteSettingsType = formatWriteSettingsType ?? "Unknown";
        }
    }
}
