// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace AzureDataFactory.TestingFramework.Models
{
    public partial class RunQueryOrderBy : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("orderBy"u8);
            writer.WriteStringValue(OrderBy.ToString());
            writer.WritePropertyName("order"u8);
            writer.WriteStringValue(Order.ToString());
            writer.WriteEndObject();
        }
    }
}
