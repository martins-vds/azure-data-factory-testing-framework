// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.ComponentModel;

namespace AzureDataFactory.TestingFramework.Models
{
    /// <summary> The authentication method used to access the Spark server. </summary>
    public readonly partial struct SparkAuthenticationType : IEquatable<SparkAuthenticationType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="SparkAuthenticationType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public SparkAuthenticationType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string AnonymousValue = "Anonymous";
        private const string UsernameValue = "Username";
        private const string UsernameAndPasswordValue = "UsernameAndPassword";
        private const string WindowsAzureHDInsightServiceValue = "WindowsAzureHDInsightService";

        /// <summary> Anonymous. </summary>
        public static SparkAuthenticationType Anonymous { get; } = new SparkAuthenticationType(AnonymousValue);
        /// <summary> Username. </summary>
        public static SparkAuthenticationType Username { get; } = new SparkAuthenticationType(UsernameValue);
        /// <summary> UsernameAndPassword. </summary>
        public static SparkAuthenticationType UsernameAndPassword { get; } = new SparkAuthenticationType(UsernameAndPasswordValue);
        /// <summary> WindowsAzureHDInsightService. </summary>
        public static SparkAuthenticationType WindowsAzureHDInsightService { get; } = new SparkAuthenticationType(WindowsAzureHDInsightServiceValue);
        /// <summary> Determines if two <see cref="SparkAuthenticationType"/> values are the same. </summary>
        public static bool operator ==(SparkAuthenticationType left, SparkAuthenticationType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="SparkAuthenticationType"/> values are not the same. </summary>
        public static bool operator !=(SparkAuthenticationType left, SparkAuthenticationType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="SparkAuthenticationType"/>. </summary>
        public static implicit operator SparkAuthenticationType(string value) => new SparkAuthenticationType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is SparkAuthenticationType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(SparkAuthenticationType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
