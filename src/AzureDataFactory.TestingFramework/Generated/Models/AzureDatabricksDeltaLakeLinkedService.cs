// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.Core.Expressions.DataFactory;

namespace AzureDataFactory.TestingFramework.Models
{
    /// <summary> Azure Databricks Delta Lake linked service. </summary>
    public partial class AzureDatabricksDeltaLakeLinkedService : DataFactoryLinkedServiceProperties
    {
        /// <summary> Initializes a new instance of AzureDatabricksDeltaLakeLinkedService. </summary>
        /// <param name="domain"> &lt;REGION&gt;.azuredatabricks.net, domain name of your Databricks deployment. Type: string (or Expression with resultType string). </param>
        /// <exception cref="ArgumentNullException"> <paramref name="domain"/> is null. </exception>
        public AzureDatabricksDeltaLakeLinkedService(DataFactoryElement<string> domain)
        {
            Argument.AssertNotNull(domain, nameof(domain));

            Domain = domain;
            LinkedServiceType = "AzureDatabricksDeltaLake";
        }

        /// <summary> Initializes a new instance of AzureDatabricksDeltaLakeLinkedService. </summary>
        /// <param name="linkedServiceType"> Type of linked service. </param>
        /// <param name="connectVia"> The integration runtime reference. </param>
        /// <param name="description"> Linked service description. </param>
        /// <param name="parameters"> Parameters for linked service. </param>
        /// <param name="annotations"> List of tags that can be used for describing the linked service. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="domain"> &lt;REGION&gt;.azuredatabricks.net, domain name of your Databricks deployment. Type: string (or Expression with resultType string). </param>
        /// <param name="accessToken"> Access token for databricks REST API. Refer to https://docs.azuredatabricks.net/api/latest/authentication.html. Type: string, SecureString or AzureKeyVaultSecretReference. </param>
        /// <param name="clusterId"> The id of an existing interactive cluster that will be used for all runs of this job. Type: string (or Expression with resultType string). </param>
        /// <param name="encryptedCredential"> The encrypted credential used for authentication. Credentials are encrypted using the integration runtime credential manager. Type: string. </param>
        /// <param name="credential"> The credential reference containing authentication information. </param>
        /// <param name="workspaceResourceId"> Workspace resource id for databricks REST API. Type: string (or Expression with resultType string). </param>
        internal AzureDatabricksDeltaLakeLinkedService(string linkedServiceType, IntegrationRuntimeReference connectVia, string description, IDictionary<string, EntityParameterSpecification> parameters, IList<BinaryData> annotations, IDictionary<string, BinaryData> additionalProperties, DataFactoryElement<string> domain, DataFactorySecretBaseDefinition accessToken, DataFactoryElement<string> clusterId, string encryptedCredential, DataFactoryCredentialReference credential, DataFactoryElement<string> workspaceResourceId) : base(linkedServiceType, connectVia, description, parameters, annotations, additionalProperties)
        {
            Domain = domain;
            AccessToken = accessToken;
            ClusterId = clusterId;
            EncryptedCredential = encryptedCredential;
            Credential = credential;
            WorkspaceResourceId = workspaceResourceId;
            LinkedServiceType = linkedServiceType ?? "AzureDatabricksDeltaLake";
        }

        /// <summary> &lt;REGION&gt;.azuredatabricks.net, domain name of your Databricks deployment. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> Domain { get; set; }
        /// <summary> Access token for databricks REST API. Refer to https://docs.azuredatabricks.net/api/latest/authentication.html. Type: string, SecureString or AzureKeyVaultSecretReference. </summary>
        public DataFactorySecretBaseDefinition AccessToken { get; set; }
        /// <summary> The id of an existing interactive cluster that will be used for all runs of this job. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> ClusterId { get; set; }
        /// <summary> The encrypted credential used for authentication. Credentials are encrypted using the integration runtime credential manager. Type: string. </summary>
        public string EncryptedCredential { get; set; }
        /// <summary> The credential reference containing authentication information. </summary>
        public DataFactoryCredentialReference Credential { get; set; }
        /// <summary> Workspace resource id for databricks REST API. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> WorkspaceResourceId { get; set; }
    }
}
