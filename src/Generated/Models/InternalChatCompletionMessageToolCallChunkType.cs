// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace OpenAI.Chat
{
    internal readonly partial struct InternalChatCompletionMessageToolCallChunkType : IEquatable<InternalChatCompletionMessageToolCallChunkType>
    {
        private readonly string _value;

        public InternalChatCompletionMessageToolCallChunkType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string FunctionValue = "function";

        public static InternalChatCompletionMessageToolCallChunkType Function { get; } = new InternalChatCompletionMessageToolCallChunkType(FunctionValue);
        public static bool operator ==(InternalChatCompletionMessageToolCallChunkType left, InternalChatCompletionMessageToolCallChunkType right) => left.Equals(right);
        public static bool operator !=(InternalChatCompletionMessageToolCallChunkType left, InternalChatCompletionMessageToolCallChunkType right) => !left.Equals(right);
        public static implicit operator InternalChatCompletionMessageToolCallChunkType(string value) => new InternalChatCompletionMessageToolCallChunkType(value);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is InternalChatCompletionMessageToolCallChunkType other && Equals(other);
        public bool Equals(InternalChatCompletionMessageToolCallChunkType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        public override string ToString() => _value;
    }
}
