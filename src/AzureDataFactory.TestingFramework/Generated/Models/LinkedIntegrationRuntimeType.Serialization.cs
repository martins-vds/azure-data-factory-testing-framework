// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace AzureDataFactory.TestingFramework.Models
{
    public partial class LinkedIntegrationRuntimeType : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("authorizationType"u8);
            writer.WriteStringValue(AuthorizationType);
            writer.WriteEndObject();
        }

        internal static LinkedIntegrationRuntimeType DeserializeLinkedIntegrationRuntimeType(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("authorizationType", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "Key": return LinkedIntegrationRuntimeKeyAuthorization.DeserializeLinkedIntegrationRuntimeKeyAuthorization(element);
                    case "RBAC": return LinkedIntegrationRuntimeRbacAuthorization.DeserializeLinkedIntegrationRuntimeRbacAuthorization(element);
                }
            }
            return UnknownLinkedIntegrationRuntimeType.DeserializeUnknownLinkedIntegrationRuntimeType(element);
        }
    }
}
