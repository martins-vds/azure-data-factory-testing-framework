// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core.Expressions.DataFactory;

namespace AzureDataFactory.TestingFramework.Models
{
    /// <summary> The data stored in Parquet format. </summary>
    public partial class DatasetParquetFormat : DatasetStorageFormat
    {
        /// <summary> Initializes a new instance of DatasetParquetFormat. </summary>
        public DatasetParquetFormat()
        {
            DatasetStorageFormatType = "ParquetFormat";
        }

        /// <summary> Initializes a new instance of DatasetParquetFormat. </summary>
        /// <param name="datasetStorageFormatType"> Type of dataset storage format. </param>
        /// <param name="serializer"> Serializer. Type: string (or Expression with resultType string). </param>
        /// <param name="deserializer"> Deserializer. Type: string (or Expression with resultType string). </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        internal DatasetParquetFormat(string datasetStorageFormatType, DataFactoryElement<string> serializer, DataFactoryElement<string> deserializer, IDictionary<string, DataFactoryElement<string>> additionalProperties) : base(datasetStorageFormatType, serializer, deserializer, additionalProperties)
        {
            DatasetStorageFormatType = datasetStorageFormatType ?? "ParquetFormat";
        }
    }
}
