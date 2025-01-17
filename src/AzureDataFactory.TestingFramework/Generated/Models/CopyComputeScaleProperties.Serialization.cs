// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;
using Azure.Core.Expressions.DataFactory;

namespace AzureDataFactory.TestingFramework.Models
{
    public partial class CopyComputeScaleProperties : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(DataIntegrationUnit))
            {
                writer.WritePropertyName("dataIntegrationUnit"u8);
                writer.WriteNumberValue(DataIntegrationUnit.Value);
            }
            if (Optional.IsDefined(TimeToLive))
            {
                writer.WritePropertyName("timeToLive"u8);
                writer.WriteNumberValue(TimeToLive.Value);
            }
            foreach (var item in AdditionalProperties)
            {
                writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(item.Value.ToString()).RootElement);
#endif
            }
            writer.WriteEndObject();
        }

        internal static CopyComputeScaleProperties DeserializeCopyComputeScaleProperties(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<int> dataIntegrationUnit = default;
            Optional<int> timeToLive = default;
            IDictionary<string, DataFactoryElement<string>> additionalProperties = default;
            Dictionary<string, DataFactoryElement<string>> additionalPropertiesDictionary = new Dictionary<string, DataFactoryElement<string>>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("dataIntegrationUnit"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    dataIntegrationUnit = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("timeToLive"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    timeToLive = property.Value.GetInt32();
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, JsonSerializer.Deserialize<DataFactoryElement<string>>(property.Value.GetRawText()));
            }
            additionalProperties = additionalPropertiesDictionary;
            return new CopyComputeScaleProperties(Optional.ToNullable(dataIntegrationUnit), Optional.ToNullable(timeToLive), additionalProperties);
        }
    }
}
