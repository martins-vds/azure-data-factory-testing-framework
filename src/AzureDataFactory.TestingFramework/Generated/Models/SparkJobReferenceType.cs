// <auto-generated/>

#nullable disable

using System.ComponentModel;

namespace AzureDataFactory.TestingFramework.Models
{
    /// <summary> Synapse spark job reference type. </summary>
    public readonly partial struct SparkJobReferenceType : IEquatable<SparkJobReferenceType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="SparkJobReferenceType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public SparkJobReferenceType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string SparkJobDefinitionReferenceValue = "SparkJobDefinitionReference";

        /// <summary> SparkJobDefinitionReference. </summary>
        public static SparkJobReferenceType SparkJobDefinitionReference { get; } = new SparkJobReferenceType(SparkJobDefinitionReferenceValue);
        /// <summary> Determines if two <see cref="SparkJobReferenceType"/> values are the same. </summary>
        public static bool operator ==(SparkJobReferenceType left, SparkJobReferenceType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="SparkJobReferenceType"/> values are not the same. </summary>
        public static bool operator !=(SparkJobReferenceType left, SparkJobReferenceType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="SparkJobReferenceType"/>. </summary>
        public static implicit operator SparkJobReferenceType(string value) => new SparkJobReferenceType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is SparkJobReferenceType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(SparkJobReferenceType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
