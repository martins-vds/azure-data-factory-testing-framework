// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core.Expressions.DataFactory;

namespace AzureDataFactory.TestingFramework.Models
{
    /// <summary> Azure Databricks Delta Lake import command settings. </summary>
    public partial class AzureDatabricksDeltaLakeImportCommand : ImportSettings
    {
        /// <summary> Initializes a new instance of AzureDatabricksDeltaLakeImportCommand. </summary>
        public AzureDatabricksDeltaLakeImportCommand()
        {
            ImportSettingsType = "AzureDatabricksDeltaLakeImportCommand";
        }

        /// <summary> Initializes a new instance of AzureDatabricksDeltaLakeImportCommand. </summary>
        /// <param name="importSettingsType"> The import setting type. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="dateFormat"> Specify the date format for csv in Azure Databricks Delta Lake Copy. Type: string (or Expression with resultType string). </param>
        /// <param name="timestampFormat"> Specify the timestamp format for csv in Azure Databricks Delta Lake Copy. Type: string (or Expression with resultType string). </param>
        internal AzureDatabricksDeltaLakeImportCommand(string importSettingsType, IDictionary<string, BinaryData> additionalProperties, DataFactoryElement<string> dateFormat, DataFactoryElement<string> timestampFormat) : base(importSettingsType, additionalProperties)
        {
            DateFormat = dateFormat;
            TimestampFormat = timestampFormat;
            ImportSettingsType = importSettingsType ?? "AzureDatabricksDeltaLakeImportCommand";
        }

        /// <summary> Specify the date format for csv in Azure Databricks Delta Lake Copy. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> DateFormat { get; set; }
        /// <summary> Specify the timestamp format for csv in Azure Databricks Delta Lake Copy. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> TimestampFormat { get; set; }
    }
}
