// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace AzureDataFactory.TestingFramework.Models
{
    internal partial class DataFactoryPurviewConfiguration : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(PurviewResourceId))
            {
                writer.WritePropertyName("purviewResourceId"u8);
                writer.WriteStringValue(PurviewResourceId);
            }
            writer.WriteEndObject();
        }

        internal static DataFactoryPurviewConfiguration DeserializeDataFactoryPurviewConfiguration(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ResourceIdentifier> purviewResourceId = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("purviewResourceId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    purviewResourceId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
            }
            return new DataFactoryPurviewConfiguration(purviewResourceId.Value);
        }
    }
}
