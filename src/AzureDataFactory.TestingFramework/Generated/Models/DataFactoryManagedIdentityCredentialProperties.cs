// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.Core.Expressions.DataFactory;

namespace AzureDataFactory.TestingFramework.Models
{
    /// <summary> Managed identity credential. </summary>
    public partial class DataFactoryManagedIdentityCredentialProperties : DataFactoryCredential
    {
        /// <summary> Initializes a new instance of DataFactoryManagedIdentityCredentialProperties. </summary>
        public DataFactoryManagedIdentityCredentialProperties()
        {
            CredentialType = "ManagedIdentity";
        }

        /// <summary> Initializes a new instance of DataFactoryManagedIdentityCredentialProperties. </summary>
        /// <param name="credentialType"> Type of credential. </param>
        /// <param name="description"> Credential description. </param>
        /// <param name="annotations"> List of tags that can be used for describing the Credential. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="resourceId"> The resource id of user assigned managed identity. </param>
        internal DataFactoryManagedIdentityCredentialProperties(string credentialType, string description, IList<BinaryData> annotations, IDictionary<string, DataFactoryElement<string>> additionalProperties, ResourceIdentifier resourceId) : base(credentialType, description, annotations, additionalProperties)
        {
            ResourceId = resourceId;
            CredentialType = credentialType ?? "ManagedIdentity";
        }

        /// <summary> The resource id of user assigned managed identity. </summary>
        public ResourceIdentifier ResourceId { get; set; }
    }
}
