// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.Core.Expressions.DataFactory;

namespace AzureDataFactory.TestingFramework.Models
{
    /// <summary> Open Data Protocol (OData) linked service. </summary>
    public partial class ODataLinkedService : DataFactoryLinkedServiceProperties
    {
        /// <summary> Initializes a new instance of ODataLinkedService. </summary>
        /// <param name="uri"> The URL of the OData service endpoint. Type: string (or Expression with resultType string). </param>
        /// <exception cref="ArgumentNullException"> <paramref name="uri"/> is null. </exception>
        public ODataLinkedService(DataFactoryElement<string> uri)
        {
            Argument.AssertNotNull(uri, nameof(uri));

            Uri = uri;
            LinkedServiceType = "OData";
        }

        /// <summary> Initializes a new instance of ODataLinkedService. </summary>
        /// <param name="linkedServiceType"> Type of linked service. </param>
        /// <param name="connectVia"> The integration runtime reference. </param>
        /// <param name="description"> Linked service description. </param>
        /// <param name="parameters"> Parameters for linked service. </param>
        /// <param name="annotations"> List of tags that can be used for describing the linked service. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="uri"> The URL of the OData service endpoint. Type: string (or Expression with resultType string). </param>
        /// <param name="authenticationType"> Type of authentication used to connect to the OData service. </param>
        /// <param name="userName"> User name of the OData service. Type: string (or Expression with resultType string). </param>
        /// <param name="password"> Password of the OData service. </param>
        /// <param name="authHeaders"> The additional HTTP headers in the request to RESTful API used for authorization. Type: object (or Expression with resultType object). </param>
        /// <param name="tenant"> Specify the tenant information (domain name or tenant ID) under which your application resides. Type: string (or Expression with resultType string). </param>
        /// <param name="servicePrincipalId"> Specify the application id of your application registered in Azure Active Directory. Type: string (or Expression with resultType string). </param>
        /// <param name="azureCloudType"> Indicates the azure cloud type of the service principle auth. Allowed values are AzurePublic, AzureChina, AzureUsGovernment, AzureGermany. Default value is the data factory regions’ cloud type. Type: string (or Expression with resultType string). </param>
        /// <param name="aadResourceId"> Specify the resource you are requesting authorization to use Directory. Type: string (or Expression with resultType string). </param>
        /// <param name="aadServicePrincipalCredentialType"> Specify the credential type (key or cert) is used for service principal. </param>
        /// <param name="servicePrincipalKey"> Specify the secret of your application registered in Azure Active Directory. Type: string (or Expression with resultType string). </param>
        /// <param name="servicePrincipalEmbeddedCert"> Specify the base64 encoded certificate of your application registered in Azure Active Directory. Type: string (or Expression with resultType string). </param>
        /// <param name="servicePrincipalEmbeddedCertPassword"> Specify the password of your certificate if your certificate has a password and you are using AadServicePrincipal authentication. Type: string (or Expression with resultType string). </param>
        /// <param name="encryptedCredential"> The encrypted credential used for authentication. Credentials are encrypted using the integration runtime credential manager. Type: string. </param>
        internal ODataLinkedService(string linkedServiceType, IntegrationRuntimeReference connectVia, string description, IDictionary<string, EntityParameterSpecification> parameters, IList<BinaryData> annotations, IDictionary<string, BinaryData> additionalProperties, DataFactoryElement<string> uri, ODataAuthenticationType? authenticationType, DataFactoryElement<string> userName, DataFactorySecretBaseDefinition password, DataFactoryElement<BinaryData> authHeaders, DataFactoryElement<string> tenant, DataFactoryElement<string> servicePrincipalId, DataFactoryElement<string> azureCloudType, DataFactoryElement<string> aadResourceId, ODataAadServicePrincipalCredentialType? aadServicePrincipalCredentialType, DataFactorySecretBaseDefinition servicePrincipalKey, DataFactorySecretBaseDefinition servicePrincipalEmbeddedCert, DataFactorySecretBaseDefinition servicePrincipalEmbeddedCertPassword, string encryptedCredential) : base(linkedServiceType, connectVia, description, parameters, annotations, additionalProperties)
        {
            Uri = uri;
            AuthenticationType = authenticationType;
            UserName = userName;
            Password = password;
            AuthHeaders = authHeaders;
            Tenant = tenant;
            ServicePrincipalId = servicePrincipalId;
            AzureCloudType = azureCloudType;
            AadResourceId = aadResourceId;
            AadServicePrincipalCredentialType = aadServicePrincipalCredentialType;
            ServicePrincipalKey = servicePrincipalKey;
            ServicePrincipalEmbeddedCert = servicePrincipalEmbeddedCert;
            ServicePrincipalEmbeddedCertPassword = servicePrincipalEmbeddedCertPassword;
            EncryptedCredential = encryptedCredential;
            LinkedServiceType = linkedServiceType ?? "OData";
        }

        /// <summary> The URL of the OData service endpoint. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> Uri { get; set; }
        /// <summary> Type of authentication used to connect to the OData service. </summary>
        public ODataAuthenticationType? AuthenticationType { get; set; }
        /// <summary> User name of the OData service. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> UserName { get; set; }
        /// <summary> Password of the OData service. </summary>
        public DataFactorySecretBaseDefinition Password { get; set; }
        /// <summary> The additional HTTP headers in the request to RESTful API used for authorization. Type: object (or Expression with resultType object). </summary>
        public DataFactoryElement<BinaryData> AuthHeaders { get; set; }
        /// <summary> Specify the tenant information (domain name or tenant ID) under which your application resides. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> Tenant { get; set; }
        /// <summary> Specify the application id of your application registered in Azure Active Directory. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> ServicePrincipalId { get; set; }
        /// <summary> Indicates the azure cloud type of the service principle auth. Allowed values are AzurePublic, AzureChina, AzureUsGovernment, AzureGermany. Default value is the data factory regions’ cloud type. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> AzureCloudType { get; set; }
        /// <summary> Specify the resource you are requesting authorization to use Directory. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> AadResourceId { get; set; }
        /// <summary> Specify the credential type (key or cert) is used for service principal. </summary>
        public ODataAadServicePrincipalCredentialType? AadServicePrincipalCredentialType { get; set; }
        /// <summary> Specify the secret of your application registered in Azure Active Directory. Type: string (or Expression with resultType string). </summary>
        public DataFactorySecretBaseDefinition ServicePrincipalKey { get; set; }
        /// <summary> Specify the base64 encoded certificate of your application registered in Azure Active Directory. Type: string (or Expression with resultType string). </summary>
        public DataFactorySecretBaseDefinition ServicePrincipalEmbeddedCert { get; set; }
        /// <summary> Specify the password of your certificate if your certificate has a password and you are using AadServicePrincipal authentication. Type: string (or Expression with resultType string). </summary>
        public DataFactorySecretBaseDefinition ServicePrincipalEmbeddedCertPassword { get; set; }
        /// <summary> The encrypted credential used for authentication. Credentials are encrypted using the integration runtime credential manager. Type: string. </summary>
        public string EncryptedCredential { get; set; }
    }
}
