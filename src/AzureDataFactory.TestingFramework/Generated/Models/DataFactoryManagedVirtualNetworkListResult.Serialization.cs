// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.DataFactory;

namespace AzureDataFactory.TestingFramework.Models
{
    internal partial class DataFactoryManagedVirtualNetworkListResult
    {
        internal static DataFactoryManagedVirtualNetworkListResult DeserializeDataFactoryManagedVirtualNetworkListResult(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyList<DataFactoryManagedVirtualNetworkData> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    List<DataFactoryManagedVirtualNetworkData> array = new List<DataFactoryManagedVirtualNetworkData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DataFactoryManagedVirtualNetworkData.DeserializeDataFactoryManagedVirtualNetworkData(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("nextLink"u8))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
            }
            return new DataFactoryManagedVirtualNetworkListResult(value, nextLink.Value);
        }
    }
}
