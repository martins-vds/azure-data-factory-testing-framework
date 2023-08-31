// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core.Expressions.DataFactory;

namespace AzureDataFactory.TestingFramework.Models
{
    /// <summary> QuickBooks server linked service. </summary>
    public partial class QuickBooksLinkedService : DataFactoryLinkedServiceProperties
    {
        /// <summary> Initializes a new instance of QuickBooksLinkedService. </summary>
        public QuickBooksLinkedService()
        {
            LinkedServiceType = "QuickBooks";
        }

        /// <summary> Initializes a new instance of QuickBooksLinkedService. </summary>
        /// <param name="linkedServiceType"> Type of linked service. </param>
        /// <param name="connectVia"> The integration runtime reference. </param>
        /// <param name="description"> Linked service description. </param>
        /// <param name="parameters"> Parameters for linked service. </param>
        /// <param name="annotations"> List of tags that can be used for describing the linked service. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="connectionProperties"> Properties used to connect to QuickBooks. It is mutually exclusive with any other properties in the linked service. Type: object. </param>
        /// <param name="endpoint"> The endpoint of the QuickBooks server. (i.e. quickbooks.api.intuit.com). </param>
        /// <param name="companyId"> The company ID of the QuickBooks company to authorize. </param>
        /// <param name="consumerKey"> The consumer key for OAuth 1.0 authentication. </param>
        /// <param name="consumerSecret"> The consumer secret for OAuth 1.0 authentication. </param>
        /// <param name="accessToken"> The access token for OAuth 1.0 authentication. </param>
        /// <param name="accessTokenSecret"> The access token secret for OAuth 1.0 authentication. </param>
        /// <param name="useEncryptedEndpoints"> Specifies whether the data source endpoints are encrypted using HTTPS. The default value is true. </param>
        /// <param name="encryptedCredential"> The encrypted credential used for authentication. Credentials are encrypted using the integration runtime credential manager. Type: string. </param>
        internal QuickBooksLinkedService(string linkedServiceType, IntegrationRuntimeReference connectVia, string description, IDictionary<string, EntityParameterSpecification> parameters, IList<BinaryData> annotations, IDictionary<string, DataFactoryElement<string>> additionalProperties, BinaryData connectionProperties, DataFactoryElement<string> endpoint, DataFactoryElement<string> companyId, DataFactoryElement<string> consumerKey, DataFactorySecretBaseDefinition consumerSecret, DataFactorySecretBaseDefinition accessToken, DataFactorySecretBaseDefinition accessTokenSecret, DataFactoryElement<bool> useEncryptedEndpoints, string encryptedCredential) : base(linkedServiceType, connectVia, description, parameters, annotations, additionalProperties)
        {
            ConnectionProperties = connectionProperties;
            Endpoint = endpoint;
            CompanyId = companyId;
            ConsumerKey = consumerKey;
            ConsumerSecret = consumerSecret;
            AccessToken = accessToken;
            AccessTokenSecret = accessTokenSecret;
            UseEncryptedEndpoints = useEncryptedEndpoints;
            EncryptedCredential = encryptedCredential;
            LinkedServiceType = linkedServiceType ?? "QuickBooks";
        }

        /// <summary>
        /// Properties used to connect to QuickBooks. It is mutually exclusive with any other properties in the linked service. Type: object.
        /// <para>
        /// To assign an object to this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formated json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        public BinaryData ConnectionProperties { get; set; }
        /// <summary> The endpoint of the QuickBooks server. (i.e. quickbooks.api.intuit.com). </summary>
        public DataFactoryElement<string> Endpoint { get; set; }
        /// <summary> The company ID of the QuickBooks company to authorize. </summary>
        public DataFactoryElement<string> CompanyId { get; set; }
        /// <summary> The consumer key for OAuth 1.0 authentication. </summary>
        public DataFactoryElement<string> ConsumerKey { get; set; }
        /// <summary> The consumer secret for OAuth 1.0 authentication. </summary>
        public DataFactorySecretBaseDefinition ConsumerSecret { get; set; }
        /// <summary> The access token for OAuth 1.0 authentication. </summary>
        public DataFactorySecretBaseDefinition AccessToken { get; set; }
        /// <summary> The access token secret for OAuth 1.0 authentication. </summary>
        public DataFactorySecretBaseDefinition AccessTokenSecret { get; set; }
        /// <summary> Specifies whether the data source endpoints are encrypted using HTTPS. The default value is true. </summary>
        public DataFactoryElement<bool> UseEncryptedEndpoints { get; set; }
        /// <summary> The encrypted credential used for authentication. Credentials are encrypted using the integration runtime credential manager. Type: string. </summary>
        public string EncryptedCredential { get; set; }
    }
}
