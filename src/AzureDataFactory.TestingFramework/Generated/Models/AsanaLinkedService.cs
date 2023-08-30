// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.Core.Expressions.DataFactory;

namespace AzureDataFactory.TestingFramework.Models
{
    /// <summary> Linked service for Asana. </summary>
    public partial class AsanaLinkedService : DataFactoryLinkedServiceProperties
    {
        /// <summary> Initializes a new instance of AsanaLinkedService. </summary>
        /// <param name="apiToken"> The api token for the Asana source. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="apiToken"/> is null. </exception>
        public AsanaLinkedService(DataFactorySecretBaseDefinition apiToken)
        {
            Argument.AssertNotNull(apiToken, nameof(apiToken));

            ApiToken = apiToken;
            LinkedServiceType = "Asana";
        }

        /// <summary> Initializes a new instance of AsanaLinkedService. </summary>
        /// <param name="linkedServiceType"> Type of linked service. </param>
        /// <param name="connectVia"> The integration runtime reference. </param>
        /// <param name="description"> Linked service description. </param>
        /// <param name="parameters"> Parameters for linked service. </param>
        /// <param name="annotations"> List of tags that can be used for describing the linked service. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="apiToken"> The api token for the Asana source. </param>
        /// <param name="encryptedCredential"> The encrypted credential used for authentication. Credentials are encrypted using the integration runtime credential manager. Type: string. </param>
        internal AsanaLinkedService(string linkedServiceType, IntegrationRuntimeReference connectVia, string description, IDictionary<string, EntityParameterSpecification> parameters, IList<BinaryData> annotations, IDictionary<string, BinaryData> additionalProperties, DataFactorySecretBaseDefinition apiToken, string encryptedCredential) : base(linkedServiceType, connectVia, description, parameters, annotations, additionalProperties)
        {
            ApiToken = apiToken;
            EncryptedCredential = encryptedCredential;
            LinkedServiceType = linkedServiceType ?? "Asana";
        }

        /// <summary> The api token for the Asana source. </summary>
        public DataFactorySecretBaseDefinition ApiToken { get; set; }
        /// <summary> The encrypted credential used for authentication. Credentials are encrypted using the integration runtime credential manager. Type: string. </summary>
        public string EncryptedCredential { get; set; }
    }
}
