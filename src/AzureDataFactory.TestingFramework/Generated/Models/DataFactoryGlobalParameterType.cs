// <auto-generated/>

#nullable disable

using System.ComponentModel;

namespace AzureDataFactory.TestingFramework.Models
{
    /// <summary> Global Parameter type. </summary>
    public readonly partial struct DataFactoryGlobalParameterType : IEquatable<DataFactoryGlobalParameterType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="DataFactoryGlobalParameterType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public DataFactoryGlobalParameterType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string ObjectValue = "Object";
        private const string StringValue = "String";
        private const string IntValue = "Int";
        private const string FloatValue = "Float";
        private const string BoolValue = "Bool";
        private const string ArrayValue = "Array";

        /// <summary> Object. </summary>
        public static DataFactoryGlobalParameterType Object { get; } = new DataFactoryGlobalParameterType(ObjectValue);
        /// <summary> String. </summary>
        public static DataFactoryGlobalParameterType String { get; } = new DataFactoryGlobalParameterType(StringValue);
        /// <summary> Int. </summary>
        public static DataFactoryGlobalParameterType Int { get; } = new DataFactoryGlobalParameterType(IntValue);
        /// <summary> Float. </summary>
        public static DataFactoryGlobalParameterType Float { get; } = new DataFactoryGlobalParameterType(FloatValue);
        /// <summary> Bool. </summary>
        public static DataFactoryGlobalParameterType Bool { get; } = new DataFactoryGlobalParameterType(BoolValue);
        /// <summary> Array. </summary>
        public static DataFactoryGlobalParameterType Array { get; } = new DataFactoryGlobalParameterType(ArrayValue);
        /// <summary> Determines if two <see cref="DataFactoryGlobalParameterType"/> values are the same. </summary>
        public static bool operator ==(DataFactoryGlobalParameterType left, DataFactoryGlobalParameterType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="DataFactoryGlobalParameterType"/> values are not the same. </summary>
        public static bool operator !=(DataFactoryGlobalParameterType left, DataFactoryGlobalParameterType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="DataFactoryGlobalParameterType"/>. </summary>
        public static implicit operator DataFactoryGlobalParameterType(string value) => new DataFactoryGlobalParameterType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is DataFactoryGlobalParameterType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(DataFactoryGlobalParameterType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
