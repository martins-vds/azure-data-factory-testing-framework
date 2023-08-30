// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.ComponentModel;

namespace AzureDataFactory.TestingFramework.Models
{
    /// <summary> Data flow reference type. </summary>
    public readonly partial struct DataFlowReferenceType : IEquatable<DataFlowReferenceType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="DataFlowReferenceType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public DataFlowReferenceType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string DataFlowReferenceValue = "DataFlowReference";

        /// <summary> DataFlowReference. </summary>
        public static DataFlowReferenceType DataFlowReference { get; } = new DataFlowReferenceType(DataFlowReferenceValue);
        /// <summary> Determines if two <see cref="DataFlowReferenceType"/> values are the same. </summary>
        public static bool operator ==(DataFlowReferenceType left, DataFlowReferenceType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="DataFlowReferenceType"/> values are not the same. </summary>
        public static bool operator !=(DataFlowReferenceType left, DataFlowReferenceType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="DataFlowReferenceType"/>. </summary>
        public static implicit operator DataFlowReferenceType(string value) => new DataFlowReferenceType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is DataFlowReferenceType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(DataFlowReferenceType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
