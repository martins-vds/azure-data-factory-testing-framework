// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.Core.Expressions.DataFactory;

namespace AzureDataFactory.TestingFramework.Models
{
    /// <summary> Trigger that runs every time a Blob event occurs. </summary>
    public partial class DataFactoryBlobEventsTrigger : MultiplePipelineTrigger
    {
        /// <summary> Initializes a new instance of DataFactoryBlobEventsTrigger. </summary>
        /// <param name="events"> The type of events that cause this trigger to fire. </param>
        /// <param name="scope"> The ARM resource ID of the Storage Account. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="events"/> or <paramref name="scope"/> is null. </exception>
        public DataFactoryBlobEventsTrigger(IEnumerable<DataFactoryBlobEventType> events, string scope)
        {
            Argument.AssertNotNull(events, nameof(events));
            Argument.AssertNotNull(scope, nameof(scope));

            Events = events.ToList();
            Scope = scope;
            TriggerType = "BlobEventsTrigger";
        }

        /// <summary> Initializes a new instance of DataFactoryBlobEventsTrigger. </summary>
        /// <param name="triggerType"> Trigger type. </param>
        /// <param name="description"> Trigger description. </param>
        /// <param name="runtimeState"> Indicates if trigger is running or not. Updated when Start/Stop APIs are called on the Trigger. </param>
        /// <param name="annotations"> List of tags that can be used for describing the trigger. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="pipelines"> Pipelines that need to be started. </param>
        /// <param name="blobPathBeginsWith"> The blob path must begin with the pattern provided for trigger to fire. For example, '/records/blobs/december/' will only fire the trigger for blobs in the december folder under the records container. At least one of these must be provided: blobPathBeginsWith, blobPathEndsWith. </param>
        /// <param name="blobPathEndsWith"> The blob path must end with the pattern provided for trigger to fire. For example, 'december/boxes.csv' will only fire the trigger for blobs named boxes in a december folder. At least one of these must be provided: blobPathBeginsWith, blobPathEndsWith. </param>
        /// <param name="ignoreEmptyBlobs"> If set to true, blobs with zero bytes will be ignored. </param>
        /// <param name="events"> The type of events that cause this trigger to fire. </param>
        /// <param name="scope"> The ARM resource ID of the Storage Account. </param>
        internal DataFactoryBlobEventsTrigger(string triggerType, string description, DataFactoryTriggerRuntimeState? runtimeState, IList<BinaryData> annotations, IDictionary<string, DataFactoryElement<string>> additionalProperties, IList<TriggerPipelineReference> pipelines, string blobPathBeginsWith, string blobPathEndsWith, bool? ignoreEmptyBlobs, IList<DataFactoryBlobEventType> events, string scope) : base(triggerType, description, runtimeState, annotations, additionalProperties, pipelines)
        {
            BlobPathBeginsWith = blobPathBeginsWith;
            BlobPathEndsWith = blobPathEndsWith;
            IgnoreEmptyBlobs = ignoreEmptyBlobs;
            Events = events;
            Scope = scope;
            TriggerType = triggerType ?? "BlobEventsTrigger";
        }

        /// <summary> The blob path must begin with the pattern provided for trigger to fire. For example, '/records/blobs/december/' will only fire the trigger for blobs in the december folder under the records container. At least one of these must be provided: blobPathBeginsWith, blobPathEndsWith. </summary>
        public string BlobPathBeginsWith { get; set; }
        /// <summary> The blob path must end with the pattern provided for trigger to fire. For example, 'december/boxes.csv' will only fire the trigger for blobs named boxes in a december folder. At least one of these must be provided: blobPathBeginsWith, blobPathEndsWith. </summary>
        public string BlobPathEndsWith { get; set; }
        /// <summary> If set to true, blobs with zero bytes will be ignored. </summary>
        public bool? IgnoreEmptyBlobs { get; set; }
        /// <summary> The type of events that cause this trigger to fire. </summary>
        public IList<DataFactoryBlobEventType> Events { get; }
        /// <summary> The ARM resource ID of the Storage Account. </summary>
        public string Scope { get; set; }
    }
}
