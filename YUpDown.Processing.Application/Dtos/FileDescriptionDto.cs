using System.Runtime.Serialization;

namespace YUpDown.Processing.Application.Dtos
{
    [DataContract]
    public class FileDescriptionDto
    {
        [DataMember(Order = 0)]
        public FileIdDto Id { get; }

        [DataMember(Order = 1)]
        public string PhysicalPath { get; }

        [DataMember(Order = 2)]
        public long Size { get; }

        public FileDescriptionDto(FileIdDto id, string physicalPath, long size)
        {
            Id = id;
            PhysicalPath = physicalPath ?? throw new ArgumentNullException(nameof(physicalPath));
            Size = size;
        }
    }
}
