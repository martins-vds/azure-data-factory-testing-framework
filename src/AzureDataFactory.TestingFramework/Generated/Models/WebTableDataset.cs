// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.Core.Expressions.DataFactory;

namespace AzureDataFactory.TestingFramework.Models
{
    /// <summary> The dataset points to a HTML table in the web page. </summary>
    public partial class WebTableDataset : DataFactoryDatasetProperties
    {
        /// <summary> Initializes a new instance of WebTableDataset. </summary>
        /// <param name="linkedServiceName"> Linked service reference. </param>
        /// <param name="index"> The zero-based index of the table in the web page. Type: integer (or Expression with resultType integer), minimum: 0. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="linkedServiceName"/> or <paramref name="index"/> is null. </exception>
        public WebTableDataset(DataFactoryLinkedServiceReference linkedServiceName, DataFactoryElement<int> index) : base(linkedServiceName)
        {
            Argument.AssertNotNull(linkedServiceName, nameof(linkedServiceName));
            Argument.AssertNotNull(index, nameof(index));

            Index = index;
            DatasetType = "WebTable";
        }

        /// <summary> Initializes a new instance of WebTableDataset. </summary>
        /// <param name="datasetType"> Type of dataset. </param>
        /// <param name="description"> Dataset description. </param>
        /// <param name="structure"> Columns that define the structure of the dataset. Type: array (or Expression with resultType array), itemType: DatasetDataElement. </param>
        /// <param name="schema"> Columns that define the physical type schema of the dataset. Type: array (or Expression with resultType array), itemType: DatasetSchemaDataElement. </param>
        /// <param name="linkedServiceName"> Linked service reference. </param>
        /// <param name="parameters"> Parameters for dataset. </param>
        /// <param name="annotations"> List of tags that can be used for describing the Dataset. </param>
        /// <param name="folder"> The folder that this Dataset is in. If not specified, Dataset will appear at the root level. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="index"> The zero-based index of the table in the web page. Type: integer (or Expression with resultType integer), minimum: 0. </param>
        /// <param name="path"> The relative URL to the web page from the linked service URL. Type: string (or Expression with resultType string). </param>
        internal WebTableDataset(string datasetType, string description, DataFactoryElement<IList<DatasetDataElement>> structure, DataFactoryElement<IList<DatasetSchemaDataElement>> schema, DataFactoryLinkedServiceReference linkedServiceName, IDictionary<string, EntityParameterSpecification> parameters, IList<BinaryData> annotations, DatasetFolder folder, IDictionary<string, BinaryData> additionalProperties, DataFactoryElement<int> index, DataFactoryElement<string> path) : base(datasetType, description, structure, schema, linkedServiceName, parameters, annotations, folder, additionalProperties)
        {
            Index = index;
            Path = path;
            DatasetType = datasetType ?? "WebTable";
        }

        /// <summary> The zero-based index of the table in the web page. Type: integer (or Expression with resultType integer), minimum: 0. </summary>
        public DataFactoryElement<int> Index { get; set; }
        /// <summary> The relative URL to the web page from the linked service URL. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> Path { get; set; }
    }
}
