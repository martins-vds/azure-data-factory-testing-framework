// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;
using Azure.Core.Expressions.DataFactory;

namespace AzureDataFactory.TestingFramework.Models
{
    public partial class SsisLogLocation : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("logPath"u8);
            JsonSerializer.Serialize(writer, LogPath);
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(LocationType.ToString());
            writer.WritePropertyName("typeProperties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(AccessCredential))
            {
                writer.WritePropertyName("accessCredential"u8);
                writer.WriteObjectValue(AccessCredential);
            }
            if (Optional.IsDefined(LogRefreshInterval))
            {
                writer.WritePropertyName("logRefreshInterval"u8);
                JsonSerializer.Serialize(writer, LogRefreshInterval);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static SsisLogLocation DeserializeSsisLogLocation(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            DataFactoryElement<string> logPath = default;
            SsisLogLocationType type = default;
            Optional<SsisAccessCredential> accessCredential = default;
            Optional<DataFactoryElement<string>> logRefreshInterval = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("logPath"u8))
                {
                    logPath = JsonSerializer.Deserialize<DataFactoryElement<string>>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new SsisLogLocationType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("typeProperties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("accessCredential"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            accessCredential = SsisAccessCredential.DeserializeSsisAccessCredential(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("logRefreshInterval"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            logRefreshInterval = JsonSerializer.Deserialize<DataFactoryElement<string>>(property0.Value.GetRawText());
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new SsisLogLocation(logPath, type, accessCredential.Value, logRefreshInterval.Value);
        }
    }
}
