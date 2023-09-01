using System.Runtime.Serialization;

namespace YUpDown.Processing.Application.Dtos
{
    [DataContract]
    public struct TransferringIdDto
    {
        [DataMember(Order = 0)]
        public Guid Value { get; }

        public TransferringIdDto(Guid value)
        {
            Value = value;
        }
    }
}
