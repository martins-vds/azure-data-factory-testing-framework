// <auto-generated/>

#nullable disable

using Azure.Core.Expressions.DataFactory;

namespace AzureDataFactory.TestingFramework.Models
{
    /// <summary> Json read settings. </summary>
    public partial class JsonReadSettings : FormatReadSettings
    {
        /// <summary> Initializes a new instance of JsonReadSettings. </summary>
        public JsonReadSettings()
        {
            FormatReadSettingsType = "JsonReadSettings";
        }

        /// <summary> Initializes a new instance of JsonReadSettings. </summary>
        /// <param name="formatReadSettingsType"> The read setting type. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="compressionProperties">
        /// Compression settings.
        /// Please note <see cref="CompressionReadSettings"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="TarGzipReadSettings"/>, <see cref="TarReadSettings"/> and <see cref="ZipDeflateReadSettings"/>.
        /// </param>
        internal JsonReadSettings(string formatReadSettingsType, IDictionary<string, DataFactoryElement<string>> additionalProperties, CompressionReadSettings compressionProperties) : base(formatReadSettingsType, additionalProperties)
        {
            CompressionProperties = compressionProperties;
            FormatReadSettingsType = formatReadSettingsType ?? "JsonReadSettings";
        }

        /// <summary>
        /// Compression settings.
        /// Please note <see cref="CompressionReadSettings"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="TarGzipReadSettings"/>, <see cref="TarReadSettings"/> and <see cref="ZipDeflateReadSettings"/>.
        /// </summary>
        public CompressionReadSettings CompressionProperties { get; set; }
    }
}
