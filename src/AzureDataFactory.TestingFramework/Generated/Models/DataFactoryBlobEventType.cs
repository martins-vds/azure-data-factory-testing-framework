// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.ComponentModel;

namespace AzureDataFactory.TestingFramework.Models
{
    /// <summary> The DataFactoryBlobEventType. </summary>
    public readonly partial struct DataFactoryBlobEventType : IEquatable<DataFactoryBlobEventType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="DataFactoryBlobEventType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public DataFactoryBlobEventType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string MicrosoftStorageBlobCreatedValue = "Microsoft.Storage.BlobCreated";
        private const string MicrosoftStorageBlobDeletedValue = "Microsoft.Storage.BlobDeleted";

        /// <summary> Microsoft.Storage.BlobCreated. </summary>
        public static DataFactoryBlobEventType MicrosoftStorageBlobCreated { get; } = new DataFactoryBlobEventType(MicrosoftStorageBlobCreatedValue);
        /// <summary> Microsoft.Storage.BlobDeleted. </summary>
        public static DataFactoryBlobEventType MicrosoftStorageBlobDeleted { get; } = new DataFactoryBlobEventType(MicrosoftStorageBlobDeletedValue);
        /// <summary> Determines if two <see cref="DataFactoryBlobEventType"/> values are the same. </summary>
        public static bool operator ==(DataFactoryBlobEventType left, DataFactoryBlobEventType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="DataFactoryBlobEventType"/> values are not the same. </summary>
        public static bool operator !=(DataFactoryBlobEventType left, DataFactoryBlobEventType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="DataFactoryBlobEventType"/>. </summary>
        public static implicit operator DataFactoryBlobEventType(string value) => new DataFactoryBlobEventType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is DataFactoryBlobEventType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(DataFactoryBlobEventType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
