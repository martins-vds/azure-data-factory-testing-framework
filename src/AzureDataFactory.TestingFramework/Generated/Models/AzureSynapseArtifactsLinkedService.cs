// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.Core.Expressions.DataFactory;

namespace AzureDataFactory.TestingFramework.Models
{
    /// <summary> Azure Synapse Analytics (Artifacts) linked service. </summary>
    public partial class AzureSynapseArtifactsLinkedService : DataFactoryLinkedServiceProperties
    {
        /// <summary> Initializes a new instance of AzureSynapseArtifactsLinkedService. </summary>
        /// <param name="endpoint"> https://&lt;workspacename&gt;.dev.azuresynapse.net, Azure Synapse Analytics workspace URL. Type: string (or Expression with resultType string). </param>
        /// <exception cref="ArgumentNullException"> <paramref name="endpoint"/> is null. </exception>
        public AzureSynapseArtifactsLinkedService(DataFactoryElement<string> endpoint)
        {
            Argument.AssertNotNull(endpoint, nameof(endpoint));

            Endpoint = endpoint;
            LinkedServiceType = "AzureSynapseArtifacts";
        }

        /// <summary> Initializes a new instance of AzureSynapseArtifactsLinkedService. </summary>
        /// <param name="linkedServiceType"> Type of linked service. </param>
        /// <param name="connectVia"> The integration runtime reference. </param>
        /// <param name="description"> Linked service description. </param>
        /// <param name="parameters"> Parameters for linked service. </param>
        /// <param name="annotations"> List of tags that can be used for describing the linked service. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="endpoint"> https://&lt;workspacename&gt;.dev.azuresynapse.net, Azure Synapse Analytics workspace URL. Type: string (or Expression with resultType string). </param>
        /// <param name="authentication"> Required to specify MSI, if using system assigned managed identity as authentication method. Type: string (or Expression with resultType string). </param>
        /// <param name="workspaceResourceId"> The resource ID of the Synapse workspace. The format should be: /subscriptions/{subscriptionID}/resourceGroups/{resourceGroup}/providers/Microsoft.Synapse/workspaces/{workspaceName}. Type: string (or Expression with resultType string). </param>
        internal AzureSynapseArtifactsLinkedService(string linkedServiceType, IntegrationRuntimeReference connectVia, string description, IDictionary<string, EntityParameterSpecification> parameters, IList<BinaryData> annotations, IDictionary<string, BinaryData> additionalProperties, DataFactoryElement<string> endpoint, DataFactoryElement<string> authentication, DataFactoryElement<string> workspaceResourceId) : base(linkedServiceType, connectVia, description, parameters, annotations, additionalProperties)
        {
            Endpoint = endpoint;
            Authentication = authentication;
            WorkspaceResourceId = workspaceResourceId;
            LinkedServiceType = linkedServiceType ?? "AzureSynapseArtifacts";
        }

        /// <summary> https://&lt;workspacename&gt;.dev.azuresynapse.net, Azure Synapse Analytics workspace URL. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> Endpoint { get; set; }
        /// <summary> Required to specify MSI, if using system assigned managed identity as authentication method. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> Authentication { get; set; }
        /// <summary> The resource ID of the Synapse workspace. The format should be: /subscriptions/{subscriptionID}/resourceGroups/{resourceGroup}/providers/Microsoft.Synapse/workspaces/{workspaceName}. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> WorkspaceResourceId { get; set; }
    }
}
