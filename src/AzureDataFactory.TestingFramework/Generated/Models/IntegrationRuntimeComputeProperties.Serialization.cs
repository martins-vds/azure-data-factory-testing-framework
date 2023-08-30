// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace AzureDataFactory.TestingFramework.Models
{
    public partial class IntegrationRuntimeComputeProperties : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Location))
            {
                writer.WritePropertyName("location"u8);
                writer.WriteStringValue(Location.Value);
            }
            if (Optional.IsDefined(NodeSize))
            {
                writer.WritePropertyName("nodeSize"u8);
                writer.WriteStringValue(NodeSize);
            }
            if (Optional.IsDefined(NumberOfNodes))
            {
                writer.WritePropertyName("numberOfNodes"u8);
                writer.WriteNumberValue(NumberOfNodes.Value);
            }
            if (Optional.IsDefined(MaxParallelExecutionsPerNode))
            {
                writer.WritePropertyName("maxParallelExecutionsPerNode"u8);
                writer.WriteNumberValue(MaxParallelExecutionsPerNode.Value);
            }
            if (Optional.IsDefined(DataFlowProperties))
            {
                writer.WritePropertyName("dataFlowProperties"u8);
                writer.WriteObjectValue(DataFlowProperties);
            }
            if (Optional.IsDefined(VnetProperties))
            {
                writer.WritePropertyName("vNetProperties"u8);
                writer.WriteObjectValue(VnetProperties);
            }
            if (Optional.IsDefined(CopyComputeScaleProperties))
            {
                writer.WritePropertyName("copyComputeScaleProperties"u8);
                writer.WriteObjectValue(CopyComputeScaleProperties);
            }
            if (Optional.IsDefined(PipelineExternalComputeScaleProperties))
            {
                writer.WritePropertyName("pipelineExternalComputeScaleProperties"u8);
                writer.WriteObjectValue(PipelineExternalComputeScaleProperties);
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

        internal static IntegrationRuntimeComputeProperties DeserializeIntegrationRuntimeComputeProperties(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<AzureLocation> location = default;
            Optional<string> nodeSize = default;
            Optional<int> numberOfNodes = default;
            Optional<int> maxParallelExecutionsPerNode = default;
            Optional<IntegrationRuntimeDataFlowProperties> dataFlowProperties = default;
            Optional<IntegrationRuntimeVnetProperties> vnetProperties = default;
            Optional<CopyComputeScaleProperties> copyComputeScaleProperties = default;
            Optional<PipelineExternalComputeScaleProperties> pipelineExternalComputeScaleProperties = default;
            IDictionary<string, BinaryData> additionalProperties = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("location"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    location = new AzureLocation(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("nodeSize"u8))
                {
                    nodeSize = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("numberOfNodes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    numberOfNodes = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("maxParallelExecutionsPerNode"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maxParallelExecutionsPerNode = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("dataFlowProperties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    dataFlowProperties = IntegrationRuntimeDataFlowProperties.DeserializeIntegrationRuntimeDataFlowProperties(property.Value);
                    continue;
                }
                if (property.NameEquals("vNetProperties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    vnetProperties = IntegrationRuntimeVnetProperties.DeserializeIntegrationRuntimeVnetProperties(property.Value);
                    continue;
                }
                if (property.NameEquals("copyComputeScaleProperties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    copyComputeScaleProperties = CopyComputeScaleProperties.DeserializeCopyComputeScaleProperties(property.Value);
                    continue;
                }
                if (property.NameEquals("pipelineExternalComputeScaleProperties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    pipelineExternalComputeScaleProperties = PipelineExternalComputeScaleProperties.DeserializePipelineExternalComputeScaleProperties(property.Value);
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
            }
            additionalProperties = additionalPropertiesDictionary;
            return new IntegrationRuntimeComputeProperties(Optional.ToNullable(location), nodeSize.Value, Optional.ToNullable(numberOfNodes), Optional.ToNullable(maxParallelExecutionsPerNode), dataFlowProperties.Value, vnetProperties.Value, copyComputeScaleProperties.Value, pipelineExternalComputeScaleProperties.Value, additionalProperties);
        }
    }
}
