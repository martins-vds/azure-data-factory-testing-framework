// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.Core.Expressions.DataFactory;

namespace AzureDataFactory.TestingFramework.Models
{
    /// <summary> This activity suspends pipeline execution for the specified interval. </summary>
    public partial class WaitActivity : ControlActivity
    {
        /// <summary> Initializes a new instance of WaitActivity. </summary>
        /// <param name="name"> Activity name. </param>
        /// <param name="waitTimeInSeconds"> Duration in seconds. Type: integer (or Expression with resultType integer). </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="waitTimeInSeconds"/> is null. </exception>
        public WaitActivity(string name, DataFactoryElement<int> waitTimeInSeconds) : base(name)
        {
            Argument.AssertNotNull(name, nameof(name));
            Argument.AssertNotNull(waitTimeInSeconds, nameof(waitTimeInSeconds));

            WaitTimeInSeconds = waitTimeInSeconds;
            ActivityType = "Wait";
        }

        /// <summary> Initializes a new instance of WaitActivity. </summary>
        /// <param name="name"> Activity name. </param>
        /// <param name="activityType"> Type of activity. </param>
        /// <param name="description"> Activity description. </param>
        /// <param name="state"> Activity state. This is an optional property and if not provided, the state will be Active by default. </param>
        /// <param name="onInactiveMarkAs"> Status result of the activity when the state is set to Inactive. This is an optional property and if not provided when the activity is inactive, the status will be Succeeded by default. </param>
        /// <param name="dependsOn"> Activity depends on condition. </param>
        /// <param name="userProperties"> Activity user properties. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="waitTimeInSeconds"> Duration in seconds. Type: integer (or Expression with resultType integer). </param>
        internal WaitActivity(string name, string activityType, string description, PipelineActivityState? state, ActivityOnInactiveMarkAs? onInactiveMarkAs, IList<PipelineActivityDependency> dependsOn, IList<PipelineActivityUserProperty> userProperties, IDictionary<string, BinaryData> additionalProperties, DataFactoryElement<int> waitTimeInSeconds) : base(name, activityType, description, state, onInactiveMarkAs, dependsOn, userProperties, additionalProperties)
        {
            WaitTimeInSeconds = waitTimeInSeconds;
            ActivityType = activityType ?? "Wait";
        }

        /// <summary> Duration in seconds. Type: integer (or Expression with resultType integer). </summary>
        public DataFactoryElement<int> WaitTimeInSeconds { get; set; }
    }
}
