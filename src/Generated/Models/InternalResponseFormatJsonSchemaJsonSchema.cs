// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using OpenAI;

namespace OpenAI.Internal
{
    internal partial class InternalResponseFormatJsonSchemaJsonSchema
    {
        private protected IDictionary<string, BinaryData> _additionalBinaryDataProperties;

        public InternalResponseFormatJsonSchemaJsonSchema(string name)
        {
            Argument.AssertNotNull(name, nameof(name));

            Name = name;
        }

        internal InternalResponseFormatJsonSchemaJsonSchema(string description, string name, bool? strict, BinaryData schema, IDictionary<string, BinaryData> additionalBinaryDataProperties)
        {
            Description = description;
            Name = name;
            Strict = strict;
            Schema = schema;
            _additionalBinaryDataProperties = additionalBinaryDataProperties;
        }

        public string Description { get; set; }

        public string Name { get; set; }

        public bool? Strict { get; set; }

        internal IDictionary<string, BinaryData> SerializedAdditionalRawData
        {
            get => _additionalBinaryDataProperties;
            set => _additionalBinaryDataProperties = value;
        }
    }
}
