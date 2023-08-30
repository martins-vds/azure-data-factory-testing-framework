// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.Core.Expressions.DataFactory;

namespace AzureDataFactory.TestingFramework.Models
{
    /// <summary> The Amazon RDS for SQL Server dataset. </summary>
    public partial class AmazonRdsForSqlServerTableDataset : DataFactoryDatasetProperties
    {
        /// <summary> Initializes a new instance of AmazonRdsForSqlServerTableDataset. </summary>
        /// <param name="linkedServiceName"> Linked service reference. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="linkedServiceName"/> is null. </exception>
        public AmazonRdsForSqlServerTableDataset(DataFactoryLinkedServiceReference linkedServiceName) : base(linkedServiceName)
        {
            Argument.AssertNotNull(linkedServiceName, nameof(linkedServiceName));

            DatasetType = "AmazonRdsForSqlServerTable";
        }

        /// <summary> Initializes a new instance of AmazonRdsForSqlServerTableDataset. </summary>
        /// <param name="datasetType"> Type of dataset. </param>
        /// <param name="description"> Dataset description. </param>
        /// <param name="structure"> Columns that define the structure of the dataset. Type: array (or Expression with resultType array), itemType: DatasetDataElement. </param>
        /// <param name="schema"> Columns that define the physical type schema of the dataset. Type: array (or Expression with resultType array), itemType: DatasetSchemaDataElement. </param>
        /// <param name="linkedServiceName"> Linked service reference. </param>
        /// <param name="parameters"> Parameters for dataset. </param>
        /// <param name="annotations"> List of tags that can be used for describing the Dataset. </param>
        /// <param name="folder"> The folder that this Dataset is in. If not specified, Dataset will appear at the root level. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="schemaTypePropertiesSchema"> The schema name of the SQL Server dataset. Type: string (or Expression with resultType string). </param>
        /// <param name="table"> The table name of the SQL Server dataset. Type: string (or Expression with resultType string). </param>
        internal AmazonRdsForSqlServerTableDataset(string datasetType, string description, DataFactoryElement<IList<DatasetDataElement>> structure, DataFactoryElement<IList<DatasetSchemaDataElement>> schema, DataFactoryLinkedServiceReference linkedServiceName, IDictionary<string, EntityParameterSpecification> parameters, IList<BinaryData> annotations, DatasetFolder folder, IDictionary<string, BinaryData> additionalProperties, DataFactoryElement<string> schemaTypePropertiesSchema, DataFactoryElement<string> table) : base(datasetType, description, structure, schema, linkedServiceName, parameters, annotations, folder, additionalProperties)
        {
            SchemaTypePropertiesSchema = schemaTypePropertiesSchema;
            Table = table;
            DatasetType = datasetType ?? "AmazonRdsForSqlServerTable";
        }

        /// <summary> The schema name of the SQL Server dataset. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> SchemaTypePropertiesSchema { get; set; }
        /// <summary> The table name of the SQL Server dataset. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> Table { get; set; }
    }
}
