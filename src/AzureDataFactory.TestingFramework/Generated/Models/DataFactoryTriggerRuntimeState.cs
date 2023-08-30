// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.ComponentModel;

namespace AzureDataFactory.TestingFramework.Models
{
    /// <summary> Enumerates possible state of Triggers. </summary>
    public readonly partial struct DataFactoryTriggerRuntimeState : IEquatable<DataFactoryTriggerRuntimeState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="DataFactoryTriggerRuntimeState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public DataFactoryTriggerRuntimeState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string StartedValue = "Started";
        private const string StoppedValue = "Stopped";
        private const string DisabledValue = "Disabled";

        /// <summary> Started. </summary>
        public static DataFactoryTriggerRuntimeState Started { get; } = new DataFactoryTriggerRuntimeState(StartedValue);
        /// <summary> Stopped. </summary>
        public static DataFactoryTriggerRuntimeState Stopped { get; } = new DataFactoryTriggerRuntimeState(StoppedValue);
        /// <summary> Disabled. </summary>
        public static DataFactoryTriggerRuntimeState Disabled { get; } = new DataFactoryTriggerRuntimeState(DisabledValue);
        /// <summary> Determines if two <see cref="DataFactoryTriggerRuntimeState"/> values are the same. </summary>
        public static bool operator ==(DataFactoryTriggerRuntimeState left, DataFactoryTriggerRuntimeState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="DataFactoryTriggerRuntimeState"/> values are not the same. </summary>
        public static bool operator !=(DataFactoryTriggerRuntimeState left, DataFactoryTriggerRuntimeState right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="DataFactoryTriggerRuntimeState"/>. </summary>
        public static implicit operator DataFactoryTriggerRuntimeState(string value) => new DataFactoryTriggerRuntimeState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is DataFactoryTriggerRuntimeState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(DataFactoryTriggerRuntimeState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
