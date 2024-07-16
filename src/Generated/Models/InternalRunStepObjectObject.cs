// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace OpenAI.Assistants
{
    internal readonly partial struct InternalRunStepObjectObject : IEquatable<InternalRunStepObjectObject>
    {
        private readonly string _value;

        public InternalRunStepObjectObject(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string ThreadRunStepValue = "thread.run.step";

        public static InternalRunStepObjectObject ThreadRunStep { get; } = new InternalRunStepObjectObject(ThreadRunStepValue);
        public static bool operator ==(InternalRunStepObjectObject left, InternalRunStepObjectObject right) => left.Equals(right);
        public static bool operator !=(InternalRunStepObjectObject left, InternalRunStepObjectObject right) => !left.Equals(right);
        public static implicit operator InternalRunStepObjectObject(string value) => new InternalRunStepObjectObject(value);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is InternalRunStepObjectObject other && Equals(other);
        public bool Equals(InternalRunStepObjectObject other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        public override string ToString() => _value;
    }
}
