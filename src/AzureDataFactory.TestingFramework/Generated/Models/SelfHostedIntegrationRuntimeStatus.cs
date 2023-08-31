// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.Core.Expressions.DataFactory;

namespace AzureDataFactory.TestingFramework.Models
{
    /// <summary> Self-hosted integration runtime status. </summary>
    public partial class SelfHostedIntegrationRuntimeStatus : IntegrationRuntimeStatus
    {
        /// <summary> Initializes a new instance of SelfHostedIntegrationRuntimeStatus. </summary>
        internal SelfHostedIntegrationRuntimeStatus()
        {
            Nodes = new ChangeTrackingList<SelfHostedIntegrationRuntimeNode>();
            Capabilities = new ChangeTrackingDictionary<string, string>();
            ServiceUris = new ChangeTrackingList<Uri>();
            Links = new ChangeTrackingList<LinkedIntegrationRuntime>();
            RuntimeType = IntegrationRuntimeType.SelfHosted;
        }

        /// <summary> Initializes a new instance of SelfHostedIntegrationRuntimeStatus. </summary>
        /// <param name="runtimeType"> Type of integration runtime. </param>
        /// <param name="dataFactoryName"> The data factory name which the integration runtime belong to. </param>
        /// <param name="state"> The state of integration runtime. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="createdOn"> The time at which the integration runtime was created, in ISO8601 format. </param>
        /// <param name="taskQueueId"> The task queue id of the integration runtime. </param>
        /// <param name="internalChannelEncryption"> It is used to set the encryption mode for node-node communication channel (when more than 2 self-hosted integration runtime nodes exist). </param>
        /// <param name="version"> Version of the integration runtime. </param>
        /// <param name="nodes"> The list of nodes for this integration runtime. </param>
        /// <param name="scheduledUpdateOn"> The date at which the integration runtime will be scheduled to update, in ISO8601 format. </param>
        /// <param name="updateDelayOffset"> The time in the date scheduled by service to update the integration runtime, e.g., PT03H is 3 hours. </param>
        /// <param name="localTimeZoneOffset"> The local time zone offset in hours. </param>
        /// <param name="capabilities"> Object with additional information about integration runtime capabilities. </param>
        /// <param name="serviceUris"> The URLs for the services used in integration runtime backend service. </param>
        /// <param name="autoUpdate"> Whether Self-hosted integration runtime auto update has been turned on. </param>
        /// <param name="versionStatus"> Status of the integration runtime version. </param>
        /// <param name="links"> The list of linked integration runtimes that are created to share with this integration runtime. </param>
        /// <param name="pushedVersion"> The version that the integration runtime is going to update to. </param>
        /// <param name="latestVersion"> The latest version on download center. </param>
        /// <param name="autoUpdateEta"> The estimated time when the self-hosted integration runtime will be updated. </param>
        internal SelfHostedIntegrationRuntimeStatus(IntegrationRuntimeType runtimeType, string dataFactoryName, IntegrationRuntimeState? state, IReadOnlyDictionary<string, DataFactoryElement<string>> additionalProperties, DateTimeOffset? createdOn, Guid? taskQueueId, IntegrationRuntimeInternalChannelEncryptionMode? internalChannelEncryption, string version, IReadOnlyList<SelfHostedIntegrationRuntimeNode> nodes, DateTimeOffset? scheduledUpdateOn, TimeSpan? updateDelayOffset, TimeSpan? localTimeZoneOffset, IReadOnlyDictionary<string, string> capabilities, IReadOnlyList<Uri> serviceUris, IntegrationRuntimeAutoUpdateState? autoUpdate, string versionStatus, IReadOnlyList<LinkedIntegrationRuntime> links, string pushedVersion, string latestVersion, DateTimeOffset? autoUpdateEta) : base(runtimeType, dataFactoryName, state, additionalProperties)
        {
            CreatedOn = createdOn;
            TaskQueueId = taskQueueId;
            InternalChannelEncryption = internalChannelEncryption;
            Version = version;
            Nodes = nodes;
            ScheduledUpdateOn = scheduledUpdateOn;
            UpdateDelayOffset = updateDelayOffset;
            LocalTimeZoneOffset = localTimeZoneOffset;
            Capabilities = capabilities;
            ServiceUris = serviceUris;
            AutoUpdate = autoUpdate;
            VersionStatus = versionStatus;
            Links = links;
            PushedVersion = pushedVersion;
            LatestVersion = latestVersion;
            AutoUpdateEta = autoUpdateEta;
            RuntimeType = runtimeType;
        }

        /// <summary> The time at which the integration runtime was created, in ISO8601 format. </summary>
        public DateTimeOffset? CreatedOn { get; }
        /// <summary> The task queue id of the integration runtime. </summary>
        public Guid? TaskQueueId { get; }
        /// <summary> It is used to set the encryption mode for node-node communication channel (when more than 2 self-hosted integration runtime nodes exist). </summary>
        public IntegrationRuntimeInternalChannelEncryptionMode? InternalChannelEncryption { get; }
        /// <summary> Version of the integration runtime. </summary>
        public string Version { get; }
        /// <summary> The list of nodes for this integration runtime. </summary>
        public IReadOnlyList<SelfHostedIntegrationRuntimeNode> Nodes { get; }
        /// <summary> The date at which the integration runtime will be scheduled to update, in ISO8601 format. </summary>
        public DateTimeOffset? ScheduledUpdateOn { get; }
        /// <summary> The time in the date scheduled by service to update the integration runtime, e.g., PT03H is 3 hours. </summary>
        public TimeSpan? UpdateDelayOffset { get; }
        /// <summary> The local time zone offset in hours. </summary>
        public TimeSpan? LocalTimeZoneOffset { get; }
        /// <summary> Object with additional information about integration runtime capabilities. </summary>
        public IReadOnlyDictionary<string, string> Capabilities { get; }
        /// <summary> The URLs for the services used in integration runtime backend service. </summary>
        public IReadOnlyList<Uri> ServiceUris { get; }
        /// <summary> Whether Self-hosted integration runtime auto update has been turned on. </summary>
        public IntegrationRuntimeAutoUpdateState? AutoUpdate { get; }
        /// <summary> Status of the integration runtime version. </summary>
        public string VersionStatus { get; }
        /// <summary> The list of linked integration runtimes that are created to share with this integration runtime. </summary>
        public IReadOnlyList<LinkedIntegrationRuntime> Links { get; }
        /// <summary> The version that the integration runtime is going to update to. </summary>
        public string PushedVersion { get; }
        /// <summary> The latest version on download center. </summary>
        public string LatestVersion { get; }
        /// <summary> The estimated time when the self-hosted integration runtime will be updated. </summary>
        public DateTimeOffset? AutoUpdateEta { get; }
    }
}
