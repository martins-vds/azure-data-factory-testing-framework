// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;
using Azure.Core.Expressions.DataFactory;

namespace AzureDataFactory.TestingFramework.Models
{
    public partial class DatasetTextFormat : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(ColumnDelimiter))
            {
                writer.WritePropertyName("columnDelimiter"u8);
                JsonSerializer.Serialize(writer, ColumnDelimiter);
            }
            if (Optional.IsDefined(RowDelimiter))
            {
                writer.WritePropertyName("rowDelimiter"u8);
                JsonSerializer.Serialize(writer, RowDelimiter);
            }
            if (Optional.IsDefined(EscapeChar))
            {
                writer.WritePropertyName("escapeChar"u8);
                JsonSerializer.Serialize(writer, EscapeChar);
            }
            if (Optional.IsDefined(QuoteChar))
            {
                writer.WritePropertyName("quoteChar"u8);
                JsonSerializer.Serialize(writer, QuoteChar);
            }
            if (Optional.IsDefined(NullValue))
            {
                writer.WritePropertyName("nullValue"u8);
                JsonSerializer.Serialize(writer, NullValue);
            }
            if (Optional.IsDefined(EncodingName))
            {
                writer.WritePropertyName("encodingName"u8);
                JsonSerializer.Serialize(writer, EncodingName);
            }
            if (Optional.IsDefined(TreatEmptyAsNull))
            {
                writer.WritePropertyName("treatEmptyAsNull"u8);
                JsonSerializer.Serialize(writer, TreatEmptyAsNull);
            }
            if (Optional.IsDefined(SkipLineCount))
            {
                writer.WritePropertyName("skipLineCount"u8);
                JsonSerializer.Serialize(writer, SkipLineCount);
            }
            if (Optional.IsDefined(FirstRowAsHeader))
            {
                writer.WritePropertyName("firstRowAsHeader"u8);
                JsonSerializer.Serialize(writer, FirstRowAsHeader);
            }
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(DatasetStorageFormatType);
            if (Optional.IsDefined(Serializer))
            {
                writer.WritePropertyName("serializer"u8);
                JsonSerializer.Serialize(writer, Serializer);
            }
            if (Optional.IsDefined(Deserializer))
            {
                writer.WritePropertyName("deserializer"u8);
                JsonSerializer.Serialize(writer, Deserializer);
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

        internal static DatasetTextFormat DeserializeDatasetTextFormat(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<DataFactoryElement<string>> columnDelimiter = default;
            Optional<DataFactoryElement<string>> rowDelimiter = default;
            Optional<DataFactoryElement<string>> escapeChar = default;
            Optional<DataFactoryElement<string>> quoteChar = default;
            Optional<DataFactoryElement<string>> nullValue = default;
            Optional<DataFactoryElement<string>> encodingName = default;
            Optional<DataFactoryElement<bool>> treatEmptyAsNull = default;
            Optional<DataFactoryElement<int>> skipLineCount = default;
            Optional<DataFactoryElement<bool>> firstRowAsHeader = default;
            string type = default;
            Optional<DataFactoryElement<string>> serializer = default;
            Optional<DataFactoryElement<string>> deserializer = default;
            IDictionary<string, DataFactoryElement<string>> additionalProperties = default;
            Dictionary<string, DataFactoryElement<string>> additionalPropertiesDictionary = new Dictionary<string, DataFactoryElement<string>>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("columnDelimiter"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    columnDelimiter = JsonSerializer.Deserialize<DataFactoryElement<string>>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("rowDelimiter"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    rowDelimiter = JsonSerializer.Deserialize<DataFactoryElement<string>>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("escapeChar"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    escapeChar = JsonSerializer.Deserialize<DataFactoryElement<string>>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("quoteChar"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    quoteChar = JsonSerializer.Deserialize<DataFactoryElement<string>>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("nullValue"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    nullValue = JsonSerializer.Deserialize<DataFactoryElement<string>>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("encodingName"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    encodingName = JsonSerializer.Deserialize<DataFactoryElement<string>>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("treatEmptyAsNull"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    treatEmptyAsNull = JsonSerializer.Deserialize<DataFactoryElement<bool>>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("skipLineCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    skipLineCount = JsonSerializer.Deserialize<DataFactoryElement<int>>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("firstRowAsHeader"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    firstRowAsHeader = JsonSerializer.Deserialize<DataFactoryElement<bool>>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("serializer"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    serializer = JsonSerializer.Deserialize<DataFactoryElement<string>>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("deserializer"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    deserializer = JsonSerializer.Deserialize<DataFactoryElement<string>>(property.Value.GetRawText());
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, JsonSerializer.Deserialize<DataFactoryElement<string>>(property.Value.GetRawText()));
            }
            additionalProperties = additionalPropertiesDictionary;
            return new DatasetTextFormat(type, serializer.Value, deserializer.Value, additionalProperties, columnDelimiter.Value, rowDelimiter.Value, escapeChar.Value, quoteChar.Value, nullValue.Value, encodingName.Value, treatEmptyAsNull.Value, skipLineCount.Value, firstRowAsHeader.Value);
        }
    }
}
