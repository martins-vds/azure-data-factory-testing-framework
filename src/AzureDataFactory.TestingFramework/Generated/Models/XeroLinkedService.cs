// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core.Expressions.DataFactory;

namespace AzureDataFactory.TestingFramework.Models
{
    /// <summary> Xero Service linked service. </summary>
    public partial class XeroLinkedService : DataFactoryLinkedServiceProperties
    {
        /// <summary> Initializes a new instance of XeroLinkedService. </summary>
        public XeroLinkedService()
        {
            LinkedServiceType = "Xero";
        }

        /// <summary> Initializes a new instance of XeroLinkedService. </summary>
        /// <param name="linkedServiceType"> Type of linked service. </param>
        /// <param name="connectVia"> The integration runtime reference. </param>
        /// <param name="description"> Linked service description. </param>
        /// <param name="parameters"> Parameters for linked service. </param>
        /// <param name="annotations"> List of tags that can be used for describing the linked service. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="connectionProperties"> Properties used to connect to Xero. It is mutually exclusive with any other properties in the linked service. Type: object. </param>
        /// <param name="host"> The endpoint of the Xero server. (i.e. api.xero.com). </param>
        /// <param name="consumerKey"> The consumer key associated with the Xero application. </param>
        /// <param name="privateKey">
        /// The private key from the .pem file that was generated for your Xero private application. You must include all the text from the .pem file, including the Unix line endings(
        /// ).
        /// </param>
        /// <param name="useEncryptedEndpoints"> Specifies whether the data source endpoints are encrypted using HTTPS. The default value is true. </param>
        /// <param name="useHostVerification"> Specifies whether to require the host name in the server's certificate to match the host name of the server when connecting over SSL. The default value is true. </param>
        /// <param name="usePeerVerification"> Specifies whether to verify the identity of the server when connecting over SSL. The default value is true. </param>
        /// <param name="encryptedCredential"> The encrypted credential used for authentication. Credentials are encrypted using the integration runtime credential manager. Type: string. </param>
        internal XeroLinkedService(string linkedServiceType, IntegrationRuntimeReference connectVia, string description, IDictionary<string, EntityParameterSpecification> parameters, IList<BinaryData> annotations, IDictionary<string, DataFactoryElement<string>> additionalProperties, BinaryData connectionProperties, DataFactoryElement<string> host, DataFactorySecretBaseDefinition consumerKey, DataFactorySecretBaseDefinition privateKey, DataFactoryElement<bool> useEncryptedEndpoints, DataFactoryElement<bool> useHostVerification, DataFactoryElement<bool> usePeerVerification, string encryptedCredential) : base(linkedServiceType, connectVia, description, parameters, annotations, additionalProperties)
        {
            ConnectionProperties = connectionProperties;
            Host = host;
            ConsumerKey = consumerKey;
            PrivateKey = privateKey;
            UseEncryptedEndpoints = useEncryptedEndpoints;
            UseHostVerification = useHostVerification;
            UsePeerVerification = usePeerVerification;
            EncryptedCredential = encryptedCredential;
            LinkedServiceType = linkedServiceType ?? "Xero";
        }

        /// <summary>
        /// Properties used to connect to Xero. It is mutually exclusive with any other properties in the linked service. Type: object.
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
        /// <summary> The endpoint of the Xero server. (i.e. api.xero.com). </summary>
        public DataFactoryElement<string> Host { get; set; }
        /// <summary> The consumer key associated with the Xero application. </summary>
        public DataFactorySecretBaseDefinition ConsumerKey { get; set; }
        /// <summary>
        /// The private key from the .pem file that was generated for your Xero private application. You must include all the text from the .pem file, including the Unix line endings(
        /// ).
        /// </summary>
        public DataFactorySecretBaseDefinition PrivateKey { get; set; }
        /// <summary> Specifies whether the data source endpoints are encrypted using HTTPS. The default value is true. </summary>
        public DataFactoryElement<bool> UseEncryptedEndpoints { get; set; }
        /// <summary> Specifies whether to require the host name in the server's certificate to match the host name of the server when connecting over SSL. The default value is true. </summary>
        public DataFactoryElement<bool> UseHostVerification { get; set; }
        /// <summary> Specifies whether to verify the identity of the server when connecting over SSL. The default value is true. </summary>
        public DataFactoryElement<bool> UsePeerVerification { get; set; }
        /// <summary> The encrypted credential used for authentication. Credentials are encrypted using the integration runtime credential manager. Type: string. </summary>
        public string EncryptedCredential { get; set; }
    }
}
