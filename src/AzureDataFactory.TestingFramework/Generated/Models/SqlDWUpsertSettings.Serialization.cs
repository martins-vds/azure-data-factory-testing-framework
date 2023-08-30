// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;
using Azure.Core.Expressions.DataFactory;

namespace AzureDataFactory.TestingFramework.Models
{
    public partial class SqlDWUpsertSettings : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(InterimSchemaName))
            {
                writer.WritePropertyName("interimSchemaName"u8);
                JsonSerializer.Serialize(writer, InterimSchemaName);
            }
            if (Optional.IsDefined(Keys))
            {
                writer.WritePropertyName("keys"u8);
                JsonSerializer.Serialize(writer, Keys);
            }
            writer.WriteEndObject();
        }

        internal static SqlDWUpsertSettings DeserializeSqlDWUpsertSettings(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<DataFactoryElement<string>> interimSchemaName = default;
            Optional<DataFactoryElement<IList<string>>> keys = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("interimSchemaName"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    interimSchemaName = JsonSerializer.Deserialize<DataFactoryElement<string>>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("keys"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    keys = JsonSerializer.Deserialize<DataFactoryElement<IList<string>>>(property.Value.GetRawText());
                    continue;
                }
            }
            return new SqlDWUpsertSettings(interimSchemaName.Value, keys.Value);
        }
    }
}
