// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace AzureDataFactory.TestingFramework.Models
{
    public partial class DataFactoryGlobalParameterProperties : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(GlobalParameterType.ToString());
            writer.WritePropertyName("value"u8);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(Value);
#else
            JsonSerializer.Serialize(writer, JsonDocument.Parse(Value.ToString()).RootElement);
#endif
            writer.WriteEndObject();
        }

        internal static DataFactoryGlobalParameterProperties DeserializeDataFactoryGlobalParameterProperties(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            DataFactoryGlobalParameterType type = default;
            BinaryData value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"u8))
                {
                    type = new DataFactoryGlobalParameterType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("value"u8))
                {
                    value = BinaryData.FromString(property.Value.GetRawText());
                    continue;
                }
            }
            return new DataFactoryGlobalParameterProperties(type, value);
        }
    }
}
