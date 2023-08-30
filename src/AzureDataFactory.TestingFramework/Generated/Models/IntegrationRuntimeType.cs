// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.ComponentModel;

namespace AzureDataFactory.TestingFramework.Models
{
    /// <summary> The type of integration runtime. </summary>
    internal readonly partial struct IntegrationRuntimeType : IEquatable<IntegrationRuntimeType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="IntegrationRuntimeType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public IntegrationRuntimeType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string ManagedValue = "Managed";
        private const string SelfHostedValue = "SelfHosted";

        /// <summary> Managed. </summary>
        public static IntegrationRuntimeType Managed { get; } = new IntegrationRuntimeType(ManagedValue);
        /// <summary> SelfHosted. </summary>
        public static IntegrationRuntimeType SelfHosted { get; } = new IntegrationRuntimeType(SelfHostedValue);
        /// <summary> Determines if two <see cref="IntegrationRuntimeType"/> values are the same. </summary>
        public static bool operator ==(IntegrationRuntimeType left, IntegrationRuntimeType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="IntegrationRuntimeType"/> values are not the same. </summary>
        public static bool operator !=(IntegrationRuntimeType left, IntegrationRuntimeType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="IntegrationRuntimeType"/>. </summary>
        public static implicit operator IntegrationRuntimeType(string value) => new IntegrationRuntimeType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is IntegrationRuntimeType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(IntegrationRuntimeType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
