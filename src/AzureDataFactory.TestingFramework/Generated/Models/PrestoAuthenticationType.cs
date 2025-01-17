// <auto-generated/>

#nullable disable

using System.ComponentModel;

namespace AzureDataFactory.TestingFramework.Models
{
    /// <summary> The authentication mechanism used to connect to the Presto server. </summary>
    public readonly partial struct PrestoAuthenticationType : IEquatable<PrestoAuthenticationType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="PrestoAuthenticationType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public PrestoAuthenticationType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string AnonymousValue = "Anonymous";
        private const string LdapValue = "LDAP";

        /// <summary> Anonymous. </summary>
        public static PrestoAuthenticationType Anonymous { get; } = new PrestoAuthenticationType(AnonymousValue);
        /// <summary> LDAP. </summary>
        public static PrestoAuthenticationType Ldap { get; } = new PrestoAuthenticationType(LdapValue);
        /// <summary> Determines if two <see cref="PrestoAuthenticationType"/> values are the same. </summary>
        public static bool operator ==(PrestoAuthenticationType left, PrestoAuthenticationType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="PrestoAuthenticationType"/> values are not the same. </summary>
        public static bool operator !=(PrestoAuthenticationType left, PrestoAuthenticationType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="PrestoAuthenticationType"/>. </summary>
        public static implicit operator PrestoAuthenticationType(string value) => new PrestoAuthenticationType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is PrestoAuthenticationType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(PrestoAuthenticationType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
