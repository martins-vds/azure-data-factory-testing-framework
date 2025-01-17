// <auto-generated/>

#nullable disable

using System.ComponentModel;

namespace AzureDataFactory.TestingFramework.Models
{
    /// <summary> The OAuth 2.0 authentication mechanism used for authentication. ServiceAuthentication can only be used on self-hosted IR. </summary>
    public readonly partial struct GoogleAdWordsAuthenticationType : IEquatable<GoogleAdWordsAuthenticationType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="GoogleAdWordsAuthenticationType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public GoogleAdWordsAuthenticationType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string ServiceAuthenticationValue = "ServiceAuthentication";
        private const string UserAuthenticationValue = "UserAuthentication";

        /// <summary> ServiceAuthentication. </summary>
        public static GoogleAdWordsAuthenticationType ServiceAuthentication { get; } = new GoogleAdWordsAuthenticationType(ServiceAuthenticationValue);
        /// <summary> UserAuthentication. </summary>
        public static GoogleAdWordsAuthenticationType UserAuthentication { get; } = new GoogleAdWordsAuthenticationType(UserAuthenticationValue);
        /// <summary> Determines if two <see cref="GoogleAdWordsAuthenticationType"/> values are the same. </summary>
        public static bool operator ==(GoogleAdWordsAuthenticationType left, GoogleAdWordsAuthenticationType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="GoogleAdWordsAuthenticationType"/> values are not the same. </summary>
        public static bool operator !=(GoogleAdWordsAuthenticationType left, GoogleAdWordsAuthenticationType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="GoogleAdWordsAuthenticationType"/>. </summary>
        public static implicit operator GoogleAdWordsAuthenticationType(string value) => new GoogleAdWordsAuthenticationType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is GoogleAdWordsAuthenticationType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(GoogleAdWordsAuthenticationType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
