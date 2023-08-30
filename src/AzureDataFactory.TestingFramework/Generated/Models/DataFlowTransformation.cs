// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.Core.Expressions.DataFactory;

namespace AzureDataFactory.TestingFramework.Models
{
    /// <summary> A data flow transformation. </summary>
    public partial class DataFlowTransformation
    {
        /// <summary> Initializes a new instance of DataFlowTransformation. </summary>
        /// <param name="name"> Transformation name. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public DataFlowTransformation(string name)
        {
            Argument.AssertNotNull(name, nameof(name));

            Name = name;
        }

        /// <summary> Initializes a new instance of DataFlowTransformation. </summary>
        /// <param name="name"> Transformation name. </param>
        /// <param name="description"> Transformation description. </param>
        /// <param name="dataset"> Dataset reference. </param>
        /// <param name="linkedService"> Linked service reference. </param>
        /// <param name="flowlet"> Flowlet Reference. </param>
        internal DataFlowTransformation(string name, string description, DatasetReference dataset, DataFactoryLinkedServiceReference linkedService, DataFlowReference flowlet)
        {
            Name = name;
            Description = description;
            Dataset = dataset;
            LinkedService = linkedService;
            Flowlet = flowlet;
        }

        /// <summary> Transformation name. </summary>
        public string Name { get; set; }
        /// <summary> Transformation description. </summary>
        public string Description { get; set; }
        /// <summary> Dataset reference. </summary>
        public DatasetReference Dataset { get; set; }
        /// <summary> Linked service reference. </summary>
        public DataFactoryLinkedServiceReference LinkedService { get; set; }
        /// <summary> Flowlet Reference. </summary>
        public DataFlowReference Flowlet { get; set; }
    }
}
