// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using OpenAI;

namespace OpenAI.Responses
{
    public partial class StreamingResponseCreatedUpdate : IJsonModel<StreamingResponseCreatedUpdate>
    {
        internal StreamingResponseCreatedUpdate()
        {
        }

        void IJsonModel<StreamingResponseCreatedUpdate>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<StreamingResponseCreatedUpdate>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(StreamingResponseCreatedUpdate)} does not support writing '{format}' format.");
            }
            base.JsonModelWriteCore(writer, options);
            if (_additionalBinaryDataProperties?.ContainsKey("response") != true)
            {
                writer.WritePropertyName("response"u8);
                writer.WriteObjectValue(Response, options);
            }
        }

        StreamingResponseCreatedUpdate IJsonModel<StreamingResponseCreatedUpdate>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => (StreamingResponseCreatedUpdate)JsonModelCreateCore(ref reader, options);

        protected override StreamingResponseUpdate JsonModelCreateCore(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<StreamingResponseCreatedUpdate>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(StreamingResponseCreatedUpdate)} does not support reading '{format}' format.");
            }
            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeStreamingResponseCreatedUpdate(document.RootElement, options);
        }

        internal static StreamingResponseCreatedUpdate DeserializeStreamingResponseCreatedUpdate(JsonElement element, ModelReaderWriterOptions options)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            InternalResponsesResponseStreamEventType @type = default;
            IDictionary<string, BinaryData> additionalBinaryDataProperties = new ChangeTrackingDictionary<string, BinaryData>();
            OpenAIResponse response = default;
            foreach (var prop in element.EnumerateObject())
            {
                if (prop.NameEquals("type"u8))
                {
                    @type = new InternalResponsesResponseStreamEventType(prop.Value.GetString());
                    continue;
                }
                if (prop.NameEquals("response"u8))
                {
                    response = OpenAIResponse.DeserializeOpenAIResponse(prop.Value, options);
                    continue;
                }
                additionalBinaryDataProperties.Add(prop.Name, BinaryData.FromString(prop.Value.GetRawText()));
            }
            return new StreamingResponseCreatedUpdate(@type, additionalBinaryDataProperties, response);
        }

        BinaryData IPersistableModel<StreamingResponseCreatedUpdate>.Write(ModelReaderWriterOptions options) => PersistableModelWriteCore(options);

        protected override BinaryData PersistableModelWriteCore(ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<StreamingResponseCreatedUpdate>)this).GetFormatFromOptions(options) : options.Format;
            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(StreamingResponseCreatedUpdate)} does not support writing '{options.Format}' format.");
            }
        }

        StreamingResponseCreatedUpdate IPersistableModel<StreamingResponseCreatedUpdate>.Create(BinaryData data, ModelReaderWriterOptions options) => (StreamingResponseCreatedUpdate)PersistableModelCreateCore(data, options);

        protected override StreamingResponseUpdate PersistableModelCreateCore(BinaryData data, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<StreamingResponseCreatedUpdate>)this).GetFormatFromOptions(options) : options.Format;
            switch (format)
            {
                case "J":
                    using (JsonDocument document = JsonDocument.Parse(data))
                    {
                        return DeserializeStreamingResponseCreatedUpdate(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(StreamingResponseCreatedUpdate)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<StreamingResponseCreatedUpdate>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        public static implicit operator BinaryContent(StreamingResponseCreatedUpdate streamingResponseCreatedUpdate)
        {
            if (streamingResponseCreatedUpdate == null)
            {
                return null;
            }
            return BinaryContent.Create(streamingResponseCreatedUpdate, ModelSerializationExtensions.WireOptions);
        }

        public static explicit operator StreamingResponseCreatedUpdate(ClientResult result)
        {
            using PipelineResponse response = result.GetRawResponse();
            using JsonDocument document = JsonDocument.Parse(response.Content);
            return DeserializeStreamingResponseCreatedUpdate(document.RootElement, ModelSerializationExtensions.WireOptions);
        }
    }
}
