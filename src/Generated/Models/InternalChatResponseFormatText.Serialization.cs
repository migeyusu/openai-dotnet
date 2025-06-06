// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using OpenAI;

namespace OpenAI.Chat
{
    internal partial class InternalChatResponseFormatText : IJsonModel<InternalChatResponseFormatText>
    {
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<InternalChatResponseFormatText>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InternalChatResponseFormatText)} does not support writing '{format}' format.");
            }
            base.JsonModelWriteCore(writer, options);
        }

        InternalChatResponseFormatText IJsonModel<InternalChatResponseFormatText>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => (InternalChatResponseFormatText)JsonModelCreateCore(ref reader, options);

        protected override ChatResponseFormat JsonModelCreateCore(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<InternalChatResponseFormatText>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InternalChatResponseFormatText)} does not support reading '{format}' format.");
            }
            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeInternalChatResponseFormatText(document.RootElement, options);
        }

        internal static InternalChatResponseFormatText DeserializeInternalChatResponseFormatText(JsonElement element, ModelReaderWriterOptions options)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string @type = "text";
            IDictionary<string, BinaryData> additionalBinaryDataProperties = new ChangeTrackingDictionary<string, BinaryData>();
            foreach (var prop in element.EnumerateObject())
            {
                if (prop.NameEquals("type"u8))
                {
                    @type = prop.Value.GetString();
                    continue;
                }
                additionalBinaryDataProperties.Add(prop.Name, BinaryData.FromString(prop.Value.GetRawText()));
            }
            return new InternalChatResponseFormatText(@type, additionalBinaryDataProperties);
        }

        BinaryData IPersistableModel<InternalChatResponseFormatText>.Write(ModelReaderWriterOptions options) => PersistableModelWriteCore(options);

        protected override BinaryData PersistableModelWriteCore(ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<InternalChatResponseFormatText>)this).GetFormatFromOptions(options) : options.Format;
            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(InternalChatResponseFormatText)} does not support writing '{options.Format}' format.");
            }
        }

        InternalChatResponseFormatText IPersistableModel<InternalChatResponseFormatText>.Create(BinaryData data, ModelReaderWriterOptions options) => (InternalChatResponseFormatText)PersistableModelCreateCore(data, options);

        protected override ChatResponseFormat PersistableModelCreateCore(BinaryData data, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<InternalChatResponseFormatText>)this).GetFormatFromOptions(options) : options.Format;
            switch (format)
            {
                case "J":
                    using (JsonDocument document = JsonDocument.Parse(data))
                    {
                        return DeserializeInternalChatResponseFormatText(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(InternalChatResponseFormatText)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<InternalChatResponseFormatText>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        public static implicit operator BinaryContent(InternalChatResponseFormatText internalChatResponseFormatText)
        {
            if (internalChatResponseFormatText == null)
            {
                return null;
            }
            return BinaryContent.Create(internalChatResponseFormatText, ModelSerializationExtensions.WireOptions);
        }

        public static explicit operator InternalChatResponseFormatText(ClientResult result)
        {
            using PipelineResponse response = result.GetRawResponse();
            using JsonDocument document = JsonDocument.Parse(response.Content);
            return DeserializeInternalChatResponseFormatText(document.RootElement, ModelSerializationExtensions.WireOptions);
        }
    }
}
