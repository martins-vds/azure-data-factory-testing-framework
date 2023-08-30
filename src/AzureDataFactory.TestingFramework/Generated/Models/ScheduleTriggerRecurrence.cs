// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;

namespace AzureDataFactory.TestingFramework.Models
{
    /// <summary> The workflow trigger recurrence. </summary>
    public partial class ScheduleTriggerRecurrence
    {
        /// <summary> Initializes a new instance of ScheduleTriggerRecurrence. </summary>
        public ScheduleTriggerRecurrence()
        {
            AdditionalProperties = new ChangeTrackingDictionary<string, BinaryData>();
        }

        /// <summary> Initializes a new instance of ScheduleTriggerRecurrence. </summary>
        /// <param name="frequency"> The frequency. </param>
        /// <param name="interval"> The interval. </param>
        /// <param name="startOn"> The start time. </param>
        /// <param name="endOn"> The end time. </param>
        /// <param name="timeZone"> The time zone. </param>
        /// <param name="schedule"> The recurrence schedule. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        internal ScheduleTriggerRecurrence(DataFactoryRecurrenceFrequency? frequency, int? interval, DateTimeOffset? startOn, DateTimeOffset? endOn, string timeZone, DataFactoryRecurrenceSchedule schedule, IDictionary<string, BinaryData> additionalProperties)
        {
            Frequency = frequency;
            Interval = interval;
            StartOn = startOn;
            EndOn = endOn;
            TimeZone = timeZone;
            Schedule = schedule;
            AdditionalProperties = additionalProperties;
        }

        /// <summary> The frequency. </summary>
        public DataFactoryRecurrenceFrequency? Frequency { get; set; }
        /// <summary> The interval. </summary>
        public int? Interval { get; set; }
        /// <summary> The start time. </summary>
        public DateTimeOffset? StartOn { get; set; }
        /// <summary> The end time. </summary>
        public DateTimeOffset? EndOn { get; set; }
        /// <summary> The time zone. </summary>
        public string TimeZone { get; set; }
        /// <summary> The recurrence schedule. </summary>
        public DataFactoryRecurrenceSchedule Schedule { get; set; }
        /// <summary>
        /// Additional Properties
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formated json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        public IDictionary<string, BinaryData> AdditionalProperties { get; }
    }
}
