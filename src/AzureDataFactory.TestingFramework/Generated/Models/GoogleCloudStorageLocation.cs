// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core.Expressions.DataFactory;

namespace AzureDataFactory.TestingFramework.Models
{
    /// <summary> The location of Google Cloud Storage dataset. </summary>
    public partial class GoogleCloudStorageLocation : DatasetLocation
    {
        /// <summary> Initializes a new instance of GoogleCloudStorageLocation. </summary>
        public GoogleCloudStorageLocation()
        {
            DatasetLocationType = "GoogleCloudStorageLocation";
        }

        /// <summary> Initializes a new instance of GoogleCloudStorageLocation. </summary>
        /// <param name="datasetLocationType"> Type of dataset storage location. </param>
        /// <param name="folderPath"> Specify the folder path of dataset. Type: string (or Expression with resultType string). </param>
        /// <param name="fileName"> Specify the file name of dataset. Type: string (or Expression with resultType string). </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="bucketName"> Specify the bucketName of Google Cloud Storage. Type: string (or Expression with resultType string). </param>
        /// <param name="version"> Specify the version of Google Cloud Storage. Type: string (or Expression with resultType string). </param>
        internal GoogleCloudStorageLocation(string datasetLocationType, DataFactoryElement<string> folderPath, DataFactoryElement<string> fileName, IDictionary<string, DataFactoryElement<string>> additionalProperties, DataFactoryElement<string> bucketName, DataFactoryElement<string> version) : base(datasetLocationType, folderPath, fileName, additionalProperties)
        {
            BucketName = bucketName;
            Version = version;
            DatasetLocationType = datasetLocationType ?? "GoogleCloudStorageLocation";
        }

        /// <summary> Specify the bucketName of Google Cloud Storage. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> BucketName { get; set; }
        /// <summary> Specify the version of Google Cloud Storage. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> Version { get; set; }
    }
}
