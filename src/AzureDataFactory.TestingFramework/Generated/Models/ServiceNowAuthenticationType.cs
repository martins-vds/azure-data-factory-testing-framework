// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.ComponentModel;

namespace AzureDataFactory.TestingFramework.Models
{
    /// <summary> The authentication type to use. </summary>
    public readonly partial struct ServiceNowAuthenticationType : IEquatable<ServiceNowAuthenticationType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ServiceNowAuthenticationType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ServiceNowAuthenticationType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string BasicValue = "Basic";
        private const string OAuth2Value = "OAuth2";

        /// <summary> Basic. </summary>
        public static ServiceNowAuthenticationType Basic { get; } = new ServiceNowAuthenticationType(BasicValue);
        /// <summary> OAuth2. </summary>
        public static ServiceNowAuthenticationType OAuth2 { get; } = new ServiceNowAuthenticationType(OAuth2Value);
        /// <summary> Determines if two <see cref="ServiceNowAuthenticationType"/> values are the same. </summary>
        public static bool operator ==(ServiceNowAuthenticationType left, ServiceNowAuthenticationType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ServiceNowAuthenticationType"/> values are not the same. </summary>
        public static bool operator !=(ServiceNowAuthenticationType left, ServiceNowAuthenticationType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ServiceNowAuthenticationType"/>. </summary>
        public static implicit operator ServiceNowAuthenticationType(string value) => new ServiceNowAuthenticationType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ServiceNowAuthenticationType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ServiceNowAuthenticationType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
