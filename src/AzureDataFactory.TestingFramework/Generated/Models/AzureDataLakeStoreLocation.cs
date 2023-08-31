// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core.Expressions.DataFactory;

namespace AzureDataFactory.TestingFramework.Models
{
    /// <summary> The location of azure data lake store dataset. </summary>
    public partial class AzureDataLakeStoreLocation : DatasetLocation
    {
        /// <summary> Initializes a new instance of AzureDataLakeStoreLocation. </summary>
        public AzureDataLakeStoreLocation()
        {
            DatasetLocationType = "AzureDataLakeStoreLocation";
        }

        /// <summary> Initializes a new instance of AzureDataLakeStoreLocation. </summary>
        /// <param name="datasetLocationType"> Type of dataset storage location. </param>
        /// <param name="folderPath"> Specify the folder path of dataset. Type: string (or Expression with resultType string). </param>
        /// <param name="fileName"> Specify the file name of dataset. Type: string (or Expression with resultType string). </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        internal AzureDataLakeStoreLocation(string datasetLocationType, DataFactoryElement<string> folderPath, DataFactoryElement<string> fileName, IDictionary<string, DataFactoryElement<string>> additionalProperties) : base(datasetLocationType, folderPath, fileName, additionalProperties)
        {
            DatasetLocationType = datasetLocationType ?? "AzureDataLakeStoreLocation";
        }
    }
}
