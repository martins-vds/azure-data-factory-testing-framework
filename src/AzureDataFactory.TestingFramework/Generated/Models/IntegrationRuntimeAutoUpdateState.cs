// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.ComponentModel;

namespace AzureDataFactory.TestingFramework.Models
{
    /// <summary> The state of integration runtime auto update. </summary>
    public readonly partial struct IntegrationRuntimeAutoUpdateState : IEquatable<IntegrationRuntimeAutoUpdateState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="IntegrationRuntimeAutoUpdateState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public IntegrationRuntimeAutoUpdateState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string OnValue = "On";
        private const string OffValue = "Off";

        /// <summary> On. </summary>
        public static IntegrationRuntimeAutoUpdateState On { get; } = new IntegrationRuntimeAutoUpdateState(OnValue);
        /// <summary> Off. </summary>
        public static IntegrationRuntimeAutoUpdateState Off { get; } = new IntegrationRuntimeAutoUpdateState(OffValue);
        /// <summary> Determines if two <see cref="IntegrationRuntimeAutoUpdateState"/> values are the same. </summary>
        public static bool operator ==(IntegrationRuntimeAutoUpdateState left, IntegrationRuntimeAutoUpdateState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="IntegrationRuntimeAutoUpdateState"/> values are not the same. </summary>
        public static bool operator !=(IntegrationRuntimeAutoUpdateState left, IntegrationRuntimeAutoUpdateState right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="IntegrationRuntimeAutoUpdateState"/>. </summary>
        public static implicit operator IntegrationRuntimeAutoUpdateState(string value) => new IntegrationRuntimeAutoUpdateState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is IntegrationRuntimeAutoUpdateState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(IntegrationRuntimeAutoUpdateState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
