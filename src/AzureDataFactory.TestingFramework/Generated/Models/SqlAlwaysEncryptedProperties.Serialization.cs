// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;
using Azure.Core.Expressions.DataFactory;

namespace AzureDataFactory.TestingFramework.Models
{
    public partial class SqlAlwaysEncryptedProperties : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("alwaysEncryptedAkvAuthType"u8);
            writer.WriteStringValue(AlwaysEncryptedAkvAuthType.ToString());
            if (Optional.IsDefined(ServicePrincipalId))
            {
                writer.WritePropertyName("servicePrincipalId"u8);
                JsonSerializer.Serialize(writer, ServicePrincipalId);
            }
            if (Optional.IsDefined(ServicePrincipalKey))
            {
                writer.WritePropertyName("servicePrincipalKey"u8);
                JsonSerializer.Serialize(writer, ServicePrincipalKey);
            }
            if (Optional.IsDefined(Credential))
            {
                writer.WritePropertyName("credential"u8);
                writer.WriteObjectValue(Credential);
            }
            writer.WriteEndObject();
        }

        internal static SqlAlwaysEncryptedProperties DeserializeSqlAlwaysEncryptedProperties(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            SqlAlwaysEncryptedAkvAuthType alwaysEncryptedAkvAuthType = default;
            Optional<DataFactoryElement<string>> servicePrincipalId = default;
            Optional<DataFactorySecretBaseDefinition> servicePrincipalKey = default;
            Optional<DataFactoryCredentialReference> credential = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("alwaysEncryptedAkvAuthType"u8))
                {
                    alwaysEncryptedAkvAuthType = new SqlAlwaysEncryptedAkvAuthType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("servicePrincipalId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    servicePrincipalId = JsonSerializer.Deserialize<DataFactoryElement<string>>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("servicePrincipalKey"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    servicePrincipalKey = JsonSerializer.Deserialize<DataFactorySecretBaseDefinition>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("credential"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    credential = DataFactoryCredentialReference.DeserializeDataFactoryCredentialReference(property.Value);
                    continue;
                }
            }
            return new SqlAlwaysEncryptedProperties(alwaysEncryptedAkvAuthType, servicePrincipalId.Value, servicePrincipalKey, credential.Value);
        }
    }
}
