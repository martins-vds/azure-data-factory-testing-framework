// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;
using AzureDataFactory.TestingFramework.Models;

namespace Azure.ResourceManager.DataFactory
{
    internal class DataFactoryIntegrationRuntimeStatusResultOperationSource : IOperationSource<DataFactoryIntegrationRuntimeStatusResult>
    {
        DataFactoryIntegrationRuntimeStatusResult IOperationSource<DataFactoryIntegrationRuntimeStatusResult>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            return DataFactoryIntegrationRuntimeStatusResult.DeserializeDataFactoryIntegrationRuntimeStatusResult(document.RootElement);
        }

        async ValueTask<DataFactoryIntegrationRuntimeStatusResult> IOperationSource<DataFactoryIntegrationRuntimeStatusResult>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            return DataFactoryIntegrationRuntimeStatusResult.DeserializeDataFactoryIntegrationRuntimeStatusResult(document.RootElement);
        }
    }
}
