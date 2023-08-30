// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.ComponentModel;

namespace AzureDataFactory.TestingFramework.Models
{
    /// <summary> Status of the integration runtime node. </summary>
    public readonly partial struct SelfHostedIntegrationRuntimeNodeStatus : IEquatable<SelfHostedIntegrationRuntimeNodeStatus>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="SelfHostedIntegrationRuntimeNodeStatus"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public SelfHostedIntegrationRuntimeNodeStatus(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string NeedRegistrationValue = "NeedRegistration";
        private const string OnlineValue = "Online";
        private const string LimitedValue = "Limited";
        private const string OfflineValue = "Offline";
        private const string UpgradingValue = "Upgrading";
        private const string InitializingValue = "Initializing";
        private const string InitializeFailedValue = "InitializeFailed";

        /// <summary> NeedRegistration. </summary>
        public static SelfHostedIntegrationRuntimeNodeStatus NeedRegistration { get; } = new SelfHostedIntegrationRuntimeNodeStatus(NeedRegistrationValue);
        /// <summary> Online. </summary>
        public static SelfHostedIntegrationRuntimeNodeStatus Online { get; } = new SelfHostedIntegrationRuntimeNodeStatus(OnlineValue);
        /// <summary> Limited. </summary>
        public static SelfHostedIntegrationRuntimeNodeStatus Limited { get; } = new SelfHostedIntegrationRuntimeNodeStatus(LimitedValue);
        /// <summary> Offline. </summary>
        public static SelfHostedIntegrationRuntimeNodeStatus Offline { get; } = new SelfHostedIntegrationRuntimeNodeStatus(OfflineValue);
        /// <summary> Upgrading. </summary>
        public static SelfHostedIntegrationRuntimeNodeStatus Upgrading { get; } = new SelfHostedIntegrationRuntimeNodeStatus(UpgradingValue);
        /// <summary> Initializing. </summary>
        public static SelfHostedIntegrationRuntimeNodeStatus Initializing { get; } = new SelfHostedIntegrationRuntimeNodeStatus(InitializingValue);
        /// <summary> InitializeFailed. </summary>
        public static SelfHostedIntegrationRuntimeNodeStatus InitializeFailed { get; } = new SelfHostedIntegrationRuntimeNodeStatus(InitializeFailedValue);
        /// <summary> Determines if two <see cref="SelfHostedIntegrationRuntimeNodeStatus"/> values are the same. </summary>
        public static bool operator ==(SelfHostedIntegrationRuntimeNodeStatus left, SelfHostedIntegrationRuntimeNodeStatus right) => left.Equals(right);
        /// <summary> Determines if two <see cref="SelfHostedIntegrationRuntimeNodeStatus"/> values are not the same. </summary>
        public static bool operator !=(SelfHostedIntegrationRuntimeNodeStatus left, SelfHostedIntegrationRuntimeNodeStatus right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="SelfHostedIntegrationRuntimeNodeStatus"/>. </summary>
        public static implicit operator SelfHostedIntegrationRuntimeNodeStatus(string value) => new SelfHostedIntegrationRuntimeNodeStatus(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is SelfHostedIntegrationRuntimeNodeStatus other && Equals(other);
        /// <inheritdoc />
        public bool Equals(SelfHostedIntegrationRuntimeNodeStatus other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
