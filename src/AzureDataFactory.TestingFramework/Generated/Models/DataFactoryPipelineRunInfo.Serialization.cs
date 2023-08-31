// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;
using Azure.Core.Expressions.DataFactory;

namespace AzureDataFactory.TestingFramework.Models
{
    public partial class DataFactoryPipelineRunInfo
    {
        internal static DataFactoryPipelineRunInfo DeserializeDataFactoryPipelineRunInfo(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<Guid> runId = default;
            Optional<string> runGroupId = default;
            Optional<bool> isLatest = default;
            Optional<string> pipelineName = default;
            Optional<IReadOnlyDictionary<string, string>> parameters = default;
            Optional<IReadOnlyDictionary<string, string>> runDimensions = default;
            Optional<DataFactoryPipelineRunEntityInfo> invokedBy = default;
            Optional<DateTimeOffset> lastUpdated = default;
            Optional<DateTimeOffset> runStart = default;
            Optional<DateTimeOffset> runEnd = default;
            Optional<int> durationInMs = default;
            Optional<string> status = default;
            Optional<string> message = default;
            IReadOnlyDictionary<string, DataFactoryElement<string>> additionalProperties = default;
            Dictionary<string, DataFactoryElement<string>> additionalPropertiesDictionary = new Dictionary<string, DataFactoryElement<string>>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("runId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    runId = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("runGroupId"u8))
                {
                    runGroupId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("isLatest"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isLatest = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("pipelineName"u8))
                {
                    pipelineName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("parameters"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    parameters = dictionary;
                    continue;
                }
                if (property.NameEquals("runDimensions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    runDimensions = dictionary;
                    continue;
                }
                if (property.NameEquals("invokedBy"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    invokedBy = DataFactoryPipelineRunEntityInfo.DeserializeDataFactoryPipelineRunEntityInfo(property.Value);
                    continue;
                }
                if (property.NameEquals("lastUpdated"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastUpdated = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("runStart"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    runStart = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("runEnd"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    runEnd = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("durationInMs"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    durationInMs = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("status"u8))
                {
                    status = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("message"u8))
                {
                    message = property.Value.GetString();
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, JsonSerializer.Deserialize<DataFactoryElement<string>>(property.Value.GetRawText()));
            }
            additionalProperties = additionalPropertiesDictionary;
            return new DataFactoryPipelineRunInfo(Optional.ToNullable(runId), runGroupId.Value, Optional.ToNullable(isLatest), pipelineName.Value, Optional.ToDictionary(parameters), Optional.ToDictionary(runDimensions), invokedBy.Value, Optional.ToNullable(lastUpdated), Optional.ToNullable(runStart), Optional.ToNullable(runEnd), Optional.ToNullable(durationInMs), status.Value, message.Value, additionalProperties);
        }
    }
}
