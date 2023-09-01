using System.Runtime.Serialization;

namespace YUpDown.Processing.Application.Dtos
{
    [DataContract]
    public class TransferringDto
    {
        [DataMember(Order = 0)]
        public TransferringIdDto Id { get; }

        [DataMember(Order = 1)]
        public TransferringTokenDto Token { get; }

        [DataMember(Order = 2)]
        public TransferringType Type { get; }

        [DataMember(Order = 3)]
        public IReadOnlyList<FileDescriptionDto> FileDescriptions { get; }

        public TransferringDto(
            TransferringIdDto id,
            TransferringTokenDto token,
            TransferringType type,
            IReadOnlyList<FileDescriptionDto> fileDescriptions)
        {
            Id = id;
            Token = token;
            Type = type;
            FileDescriptions = fileDescriptions ?? throw new ArgumentNullException(nameof(fileDescriptions));
        }
    }
}
