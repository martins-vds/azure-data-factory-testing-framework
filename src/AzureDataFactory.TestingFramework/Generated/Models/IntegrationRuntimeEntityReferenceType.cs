// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.ComponentModel;

namespace AzureDataFactory.TestingFramework.Models
{
    /// <summary> The type of this referenced entity. </summary>
    public readonly partial struct IntegrationRuntimeEntityReferenceType : IEquatable<IntegrationRuntimeEntityReferenceType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="IntegrationRuntimeEntityReferenceType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public IntegrationRuntimeEntityReferenceType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string IntegrationRuntimeReferenceValue = "IntegrationRuntimeReference";
        private const string LinkedServiceReferenceValue = "LinkedServiceReference";

        /// <summary> IntegrationRuntimeReference. </summary>
        public static IntegrationRuntimeEntityReferenceType IntegrationRuntimeReference { get; } = new IntegrationRuntimeEntityReferenceType(IntegrationRuntimeReferenceValue);
        /// <summary> LinkedServiceReference. </summary>
        public static IntegrationRuntimeEntityReferenceType LinkedServiceReference { get; } = new IntegrationRuntimeEntityReferenceType(LinkedServiceReferenceValue);
        /// <summary> Determines if two <see cref="IntegrationRuntimeEntityReferenceType"/> values are the same. </summary>
        public static bool operator ==(IntegrationRuntimeEntityReferenceType left, IntegrationRuntimeEntityReferenceType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="IntegrationRuntimeEntityReferenceType"/> values are not the same. </summary>
        public static bool operator !=(IntegrationRuntimeEntityReferenceType left, IntegrationRuntimeEntityReferenceType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="IntegrationRuntimeEntityReferenceType"/>. </summary>
        public static implicit operator IntegrationRuntimeEntityReferenceType(string value) => new IntegrationRuntimeEntityReferenceType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is IntegrationRuntimeEntityReferenceType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(IntegrationRuntimeEntityReferenceType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
