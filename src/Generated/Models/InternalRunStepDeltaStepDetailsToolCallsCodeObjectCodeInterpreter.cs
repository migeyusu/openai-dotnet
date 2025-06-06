// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using OpenAI;

namespace OpenAI.Assistants
{
    internal partial class InternalRunStepDeltaStepDetailsToolCallsCodeObjectCodeInterpreter
    {
        private protected IDictionary<string, BinaryData> _additionalBinaryDataProperties;

        internal InternalRunStepDeltaStepDetailsToolCallsCodeObjectCodeInterpreter()
        {
            Outputs = new ChangeTrackingList<RunStepUpdateCodeInterpreterOutput>();
        }

        internal InternalRunStepDeltaStepDetailsToolCallsCodeObjectCodeInterpreter(string input, IReadOnlyList<RunStepUpdateCodeInterpreterOutput> outputs, IDictionary<string, BinaryData> additionalBinaryDataProperties)
        {
            Input = input;
            Outputs = outputs;
            _additionalBinaryDataProperties = additionalBinaryDataProperties;
        }

        public string Input { get; }

        public IReadOnlyList<RunStepUpdateCodeInterpreterOutput> Outputs { get; }

        internal IDictionary<string, BinaryData> SerializedAdditionalRawData
        {
            get => _additionalBinaryDataProperties;
            set => _additionalBinaryDataProperties = value;
        }
    }
}
