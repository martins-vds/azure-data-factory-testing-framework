// <auto-generated/>

#nullable disable

using System.ComponentModel;

namespace AzureDataFactory.TestingFramework.Models
{
    /// <summary> Type of integration runtime. </summary>
    public readonly partial struct IntegrationRuntimeReferenceType : IEquatable<IntegrationRuntimeReferenceType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="IntegrationRuntimeReferenceType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public IntegrationRuntimeReferenceType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string IntegrationRuntimeReferenceValue = "IntegrationRuntimeReference";

        /// <summary> IntegrationRuntimeReference. </summary>
        public static IntegrationRuntimeReferenceType IntegrationRuntimeReference { get; } = new IntegrationRuntimeReferenceType(IntegrationRuntimeReferenceValue);
        /// <summary> Determines if two <see cref="IntegrationRuntimeReferenceType"/> values are the same. </summary>
        public static bool operator ==(IntegrationRuntimeReferenceType left, IntegrationRuntimeReferenceType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="IntegrationRuntimeReferenceType"/> values are not the same. </summary>
        public static bool operator !=(IntegrationRuntimeReferenceType left, IntegrationRuntimeReferenceType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="IntegrationRuntimeReferenceType"/>. </summary>
        public static implicit operator IntegrationRuntimeReferenceType(string value) => new IntegrationRuntimeReferenceType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is IntegrationRuntimeReferenceType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(IntegrationRuntimeReferenceType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
