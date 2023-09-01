using System.Runtime.Serialization;

namespace YUpDown.Processing.Application.Dtos
{
    [DataContract]
    public struct TransferringTokenDto
    {
        [DataMember(Order = 0)]
        public string Value { get; }

        public TransferringTokenDto(string value)
        {
            Value = value ?? throw new ArgumentNullException(nameof(value));
        }
    }
}
