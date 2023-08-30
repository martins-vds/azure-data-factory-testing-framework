// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace AzureDataFactory.TestingFramework.Models
{
    public partial class ManagedIntegrationRuntimeNode
    {
        internal static ManagedIntegrationRuntimeNode DeserializeManagedIntegrationRuntimeNode(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> nodeId = default;
            Optional<ManagedIntegrationRuntimeNodeStatus> status = default;
            Optional<IReadOnlyList<ManagedIntegrationRuntimeError>> errors = default;
            IReadOnlyDictionary<string, BinaryData> additionalProperties = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("nodeId"u8))
                {
                    nodeId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("status"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    status = new ManagedIntegrationRuntimeNodeStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("errors"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ManagedIntegrationRuntimeError> array = new List<ManagedIntegrationRuntimeError>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ManagedIntegrationRuntimeError.DeserializeManagedIntegrationRuntimeError(item));
                    }
                    errors = array;
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
            }
            additionalProperties = additionalPropertiesDictionary;
            return new ManagedIntegrationRuntimeNode(nodeId.Value, Optional.ToNullable(status), Optional.ToList(errors), additionalProperties);
        }
    }
}
