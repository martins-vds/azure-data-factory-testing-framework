// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;
using Azure.Core.Expressions.DataFactory;

namespace AzureDataFactory.TestingFramework.Models
{
    public partial class DataFactoryBlobEventsTrigger : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Pipelines))
            {
                writer.WritePropertyName("pipelines"u8);
                writer.WriteStartArray();
                foreach (var item in Pipelines)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(TriggerType);
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            if (Optional.IsCollectionDefined(Annotations))
            {
                writer.WritePropertyName("annotations"u8);
                writer.WriteStartArray();
                foreach (var item in Annotations)
                {
                    if (item == null)
                    {
                        writer.WriteNullValue();
                        continue;
                    }
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item);
#else
                    JsonSerializer.Serialize(writer, JsonDocument.Parse(item.ToString()).RootElement);
#endif
                }
                writer.WriteEndArray();
            }
            writer.WritePropertyName("typeProperties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(BlobPathBeginsWith))
            {
                writer.WritePropertyName("blobPathBeginsWith"u8);
                writer.WriteStringValue(BlobPathBeginsWith);
            }
            if (Optional.IsDefined(BlobPathEndsWith))
            {
                writer.WritePropertyName("blobPathEndsWith"u8);
                writer.WriteStringValue(BlobPathEndsWith);
            }
            if (Optional.IsDefined(IgnoreEmptyBlobs))
            {
                writer.WritePropertyName("ignoreEmptyBlobs"u8);
                writer.WriteBooleanValue(IgnoreEmptyBlobs.Value);
            }
            writer.WritePropertyName("events"u8);
            writer.WriteStartArray();
            foreach (var item in Events)
            {
                writer.WriteStringValue(item.ToString());
            }
            writer.WriteEndArray();
            writer.WritePropertyName("scope"u8);
            writer.WriteStringValue(Scope);
            writer.WriteEndObject();
            foreach (var item in AdditionalProperties)
            {
                writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(item.Value.ToString()).RootElement);
#endif
            }
            writer.WriteEndObject();
        }

        internal static DataFactoryBlobEventsTrigger DeserializeDataFactoryBlobEventsTrigger(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IList<TriggerPipelineReference>> pipelines = default;
            string type = default;
            Optional<string> description = default;
            Optional<DataFactoryTriggerRuntimeState> runtimeState = default;
            Optional<IList<BinaryData>> annotations = default;
            Optional<string> blobPathBeginsWith = default;
            Optional<string> blobPathEndsWith = default;
            Optional<bool> ignoreEmptyBlobs = default;
            IList<DataFactoryBlobEventType> events = default;
            string scope = default;
            IDictionary<string, DataFactoryElement<string>> additionalProperties = default;
            Dictionary<string, DataFactoryElement<string>> additionalPropertiesDictionary = new Dictionary<string, DataFactoryElement<string>>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("pipelines"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<TriggerPipelineReference> array = new List<TriggerPipelineReference>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(TriggerPipelineReference.DeserializeTriggerPipelineReference(item));
                    }
                    pipelines = array;
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("description"u8))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("runtimeState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    runtimeState = new DataFactoryTriggerRuntimeState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("annotations"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<BinaryData> array = new List<BinaryData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(BinaryData.FromString(item.GetRawText()));
                        }
                    }
                    annotations = array;
                    continue;
                }
                if (property.NameEquals("typeProperties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("blobPathBeginsWith"u8))
                        {
                            blobPathBeginsWith = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("blobPathEndsWith"u8))
                        {
                            blobPathEndsWith = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("ignoreEmptyBlobs"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            ignoreEmptyBlobs = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("events"u8))
                        {
                            List<DataFactoryBlobEventType> array = new List<DataFactoryBlobEventType>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(new DataFactoryBlobEventType(item.GetString()));
                            }
                            events = array;
                            continue;
                        }
                        if (property0.NameEquals("scope"u8))
                        {
                            scope = property0.Value.GetString();
                            continue;
                        }
                    }
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, JsonSerializer.Deserialize<DataFactoryElement<string>>(property.Value.GetRawText()));
            }
            additionalProperties = additionalPropertiesDictionary;
            return new DataFactoryBlobEventsTrigger(type, description.Value, Optional.ToNullable(runtimeState), Optional.ToList(annotations), additionalProperties, Optional.ToList(pipelines), blobPathBeginsWith.Value, blobPathEndsWith.Value, Optional.ToNullable(ignoreEmptyBlobs), events, scope);
        }
    }
}
