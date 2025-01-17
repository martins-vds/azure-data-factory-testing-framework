// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.Core.Expressions.DataFactory;

namespace AzureDataFactory.TestingFramework.Models
{
    /// <summary> VNet properties for managed integration runtime. </summary>
    public partial class IntegrationRuntimeVnetProperties
    {
        /// <summary> Initializes a new instance of IntegrationRuntimeVnetProperties. </summary>
        public IntegrationRuntimeVnetProperties()
        {
            PublicIPs = new ChangeTrackingList<string>();
            AdditionalProperties = new ChangeTrackingDictionary<string, DataFactoryElement<string>>();
        }

        /// <summary> Initializes a new instance of IntegrationRuntimeVnetProperties. </summary>
        /// <param name="vnetId"> The ID of the VNet that this integration runtime will join. </param>
        /// <param name="subnet"> The name of the subnet this integration runtime will join. </param>
        /// <param name="publicIPs"> Resource IDs of the public IP addresses that this integration runtime will use. </param>
        /// <param name="subnetId"> The ID of subnet, to which this Azure-SSIS integration runtime will be joined. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        internal IntegrationRuntimeVnetProperties(Guid? vnetId, string subnet, IList<string> publicIPs, ResourceIdentifier subnetId, IDictionary<string, DataFactoryElement<string>> additionalProperties)
        {
            VnetId = vnetId;
            Subnet = subnet;
            PublicIPs = publicIPs;
            SubnetId = subnetId;
            AdditionalProperties = additionalProperties;
        }

        /// <summary> The ID of the VNet that this integration runtime will join. </summary>
        public Guid? VnetId { get; set; }
        /// <summary> The name of the subnet this integration runtime will join. </summary>
        public string Subnet { get; set; }
        /// <summary> Resource IDs of the public IP addresses that this integration runtime will use. </summary>
        public IList<string> PublicIPs { get; }
        /// <summary> The ID of subnet, to which this Azure-SSIS integration runtime will be joined. </summary>
        public ResourceIdentifier SubnetId { get; set; }
        /// <summary>
        /// Additional Properties
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
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
        public IDictionary<string, DataFactoryElement<string>> AdditionalProperties { get; }
    }
}
