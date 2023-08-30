// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace AzureDataFactory.TestingFramework.Models
{
    /// <summary> The folder that this Dataset is in. If not specified, Dataset will appear at the root level. </summary>
    internal partial class DatasetFolder
    {
        /// <summary> Initializes a new instance of DatasetFolder. </summary>
        public DatasetFolder()
        {
        }

        /// <summary> Initializes a new instance of DatasetFolder. </summary>
        /// <param name="name"> The name of the folder that this Dataset is in. </param>
        internal DatasetFolder(string name)
        {
            Name = name;
        }

        /// <summary> The name of the folder that this Dataset is in. </summary>
        public string Name { get; set; }
    }
}
