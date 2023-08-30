// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;
using Azure.Core.Expressions.DataFactory;

namespace AzureDataFactory.TestingFramework.Models
{
    internal partial class UnknownWebLinkedServiceTypeProperties : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("url"u8);
            JsonSerializer.Serialize(writer, Uri);
            writer.WritePropertyName("authenticationType"u8);
            writer.WriteStringValue(AuthenticationType.ToString());
            writer.WriteEndObject();
        }

        internal static UnknownWebLinkedServiceTypeProperties DeserializeUnknownWebLinkedServiceTypeProperties(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            DataFactoryElement<string> url = default;
            WebAuthenticationType authenticationType = "Unknown";
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("url"u8))
                {
                    url = JsonSerializer.Deserialize<DataFactoryElement<string>>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("authenticationType"u8))
                {
                    authenticationType = new WebAuthenticationType(property.Value.GetString());
                    continue;
                }
            }
            return new UnknownWebLinkedServiceTypeProperties(url, authenticationType);
        }
    }
}
