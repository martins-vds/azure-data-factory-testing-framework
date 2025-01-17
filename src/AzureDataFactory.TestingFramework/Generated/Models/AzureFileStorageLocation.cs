// <auto-generated/>

#nullable disable

using Azure.Core.Expressions.DataFactory;

namespace AzureDataFactory.TestingFramework.Models
{
    /// <summary> The location of file server dataset. </summary>
    public partial class AzureFileStorageLocation : DatasetLocation
    {
        /// <summary> Initializes a new instance of AzureFileStorageLocation. </summary>
        public AzureFileStorageLocation()
        {
            DatasetLocationType = "AzureFileStorageLocation";
        }

        /// <summary> Initializes a new instance of AzureFileStorageLocation. </summary>
        /// <param name="datasetLocationType"> Type of dataset storage location. </param>
        /// <param name="folderPath"> Specify the folder path of dataset. Type: string (or Expression with resultType string). </param>
        /// <param name="fileName"> Specify the file name of dataset. Type: string (or Expression with resultType string). </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        internal AzureFileStorageLocation(string datasetLocationType, DataFactoryElement<string> folderPath, DataFactoryElement<string> fileName, IDictionary<string, DataFactoryElement<string>> additionalProperties) : base(datasetLocationType, folderPath, fileName, additionalProperties)
        {
            DatasetLocationType = datasetLocationType ?? "AzureFileStorageLocation";
        }
    }
}
