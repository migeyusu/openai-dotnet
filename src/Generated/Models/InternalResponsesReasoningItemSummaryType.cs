// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;
using OpenAI;

namespace OpenAI.Responses
{
    internal readonly partial struct InternalResponsesReasoningItemSummaryType : IEquatable<InternalResponsesReasoningItemSummaryType>
    {
        private readonly string _value;
        private const string SummaryTextValue = "summary_text";

        public InternalResponsesReasoningItemSummaryType(string value)
        {
            Argument.AssertNotNull(value, nameof(value));

            _value = value;
        }

        public static InternalResponsesReasoningItemSummaryType SummaryText { get; } = new InternalResponsesReasoningItemSummaryType(SummaryTextValue);

        public static bool operator ==(InternalResponsesReasoningItemSummaryType left, InternalResponsesReasoningItemSummaryType right) => left.Equals(right);

        public static bool operator !=(InternalResponsesReasoningItemSummaryType left, InternalResponsesReasoningItemSummaryType right) => !left.Equals(right);

        public static implicit operator InternalResponsesReasoningItemSummaryType(string value) => new InternalResponsesReasoningItemSummaryType(value);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is InternalResponsesReasoningItemSummaryType other && Equals(other);

        public bool Equals(InternalResponsesReasoningItemSummaryType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;

        public override string ToString() => _value;
    }
}
