// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core.Expressions.DataFactory;

namespace AzureDataFactory.TestingFramework.Models
{
    /// <summary> Avro write settings. </summary>
    public partial class AvroWriteSettings : FormatWriteSettings
    {
        /// <summary> Initializes a new instance of AvroWriteSettings. </summary>
        public AvroWriteSettings()
        {
            FormatWriteSettingsType = "AvroWriteSettings";
        }

        /// <summary> Initializes a new instance of AvroWriteSettings. </summary>
        /// <param name="formatWriteSettingsType"> The write setting type. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="recordName"> Top level record name in write result, which is required in AVRO spec. </param>
        /// <param name="recordNamespace"> Record namespace in the write result. </param>
        /// <param name="maxRowsPerFile"> Limit the written file's row count to be smaller than or equal to the specified count. Type: integer (or Expression with resultType integer). </param>
        /// <param name="fileNamePrefix"> Specifies the file name pattern &lt;fileNamePrefix&gt;_&lt;fileIndex&gt;.&lt;fileExtension&gt; when copy from non-file based store without partitionOptions. Type: string (or Expression with resultType string). </param>
        internal AvroWriteSettings(string formatWriteSettingsType, IDictionary<string, BinaryData> additionalProperties, string recordName, string recordNamespace, DataFactoryElement<int> maxRowsPerFile, DataFactoryElement<string> fileNamePrefix) : base(formatWriteSettingsType, additionalProperties)
        {
            RecordName = recordName;
            RecordNamespace = recordNamespace;
            MaxRowsPerFile = maxRowsPerFile;
            FileNamePrefix = fileNamePrefix;
            FormatWriteSettingsType = formatWriteSettingsType ?? "AvroWriteSettings";
        }

        /// <summary> Top level record name in write result, which is required in AVRO spec. </summary>
        public string RecordName { get; set; }
        /// <summary> Record namespace in the write result. </summary>
        public string RecordNamespace { get; set; }
        /// <summary> Limit the written file's row count to be smaller than or equal to the specified count. Type: integer (or Expression with resultType integer). </summary>
        public DataFactoryElement<int> MaxRowsPerFile { get; set; }
        /// <summary> Specifies the file name pattern &lt;fileNamePrefix&gt;_&lt;fileIndex&gt;.&lt;fileExtension&gt; when copy from non-file based store without partitionOptions. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> FileNamePrefix { get; set; }
    }
}
