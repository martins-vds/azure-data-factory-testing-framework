// <auto-generated/>

#nullable disable

using System.Net;
using System.Text.Json;
using Azure.Core;

namespace AzureDataFactory.TestingFramework.Models
{
    public partial class IntegrationRuntimeNodeIPAddress
    {
        internal static IntegrationRuntimeNodeIPAddress DeserializeIntegrationRuntimeNodeIPAddress(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IPAddress> ipAddress = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("ipAddress"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    ipAddress = IPAddress.Parse(property.Value.GetString());
                    continue;
                }
            }
            return new IntegrationRuntimeNodeIPAddress(ipAddress.Value);
        }
    }
}
