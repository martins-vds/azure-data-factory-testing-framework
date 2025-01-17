// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace AzureDataFactory.TestingFramework.Models
{
    public partial class DataFactoryDataFlowStartDebugSessionResult
    {
        internal static DataFactoryDataFlowStartDebugSessionResult DeserializeDataFactoryDataFlowStartDebugSessionResult(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> jobVersion = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("jobVersion"u8))
                {
                    jobVersion = property.Value.GetString();
                    continue;
                }
            }
            return new DataFactoryDataFlowStartDebugSessionResult(jobVersion.Value);
        }
    }
}
