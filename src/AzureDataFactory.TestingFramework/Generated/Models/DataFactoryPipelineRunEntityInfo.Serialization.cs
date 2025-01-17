// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace AzureDataFactory.TestingFramework.Models
{
    public partial class DataFactoryPipelineRunEntityInfo
    {
        internal static DataFactoryPipelineRunEntityInfo DeserializeDataFactoryPipelineRunEntityInfo(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> name = default;
            Optional<string> id = default;
            Optional<string> invokedByType = default;
            Optional<string> pipelineName = default;
            Optional<Guid> pipelineRunId = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("invokedByType"u8))
                {
                    invokedByType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("pipelineName"u8))
                {
                    pipelineName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("pipelineRunId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    pipelineRunId = property.Value.GetGuid();
                    continue;
                }
            }
            return new DataFactoryPipelineRunEntityInfo(name.Value, id.Value, invokedByType.Value, pipelineName.Value, Optional.ToNullable(pipelineRunId));
        }
    }
}
