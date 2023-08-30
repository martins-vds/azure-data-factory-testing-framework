// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core.Expressions.DataFactory;

namespace AzureDataFactory.TestingFramework.Models
{
    /// <summary> The location of azure blobFS dataset. </summary>
    public partial class AzureBlobFSLocation : DatasetLocation
    {
        /// <summary> Initializes a new instance of AzureBlobFSLocation. </summary>
        public AzureBlobFSLocation()
        {
            DatasetLocationType = "AzureBlobFSLocation";
        }

        /// <summary> Initializes a new instance of AzureBlobFSLocation. </summary>
        /// <param name="datasetLocationType"> Type of dataset storage location. </param>
        /// <param name="folderPath"> Specify the folder path of dataset. Type: string (or Expression with resultType string). </param>
        /// <param name="fileName"> Specify the file name of dataset. Type: string (or Expression with resultType string). </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="fileSystem"> Specify the fileSystem of azure blobFS. Type: string (or Expression with resultType string). </param>
        internal AzureBlobFSLocation(string datasetLocationType, DataFactoryElement<string> folderPath, DataFactoryElement<string> fileName, IDictionary<string, BinaryData> additionalProperties, DataFactoryElement<string> fileSystem) : base(datasetLocationType, folderPath, fileName, additionalProperties)
        {
            FileSystem = fileSystem;
            DatasetLocationType = datasetLocationType ?? "AzureBlobFSLocation";
        }

        /// <summary> Specify the fileSystem of azure blobFS. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> FileSystem { get; set; }
    }
}
