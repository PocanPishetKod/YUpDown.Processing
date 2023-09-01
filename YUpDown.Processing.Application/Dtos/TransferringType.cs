using System.Runtime.Serialization;

namespace YUpDown.Processing.Application.Dtos
{
    [DataContract]
    public enum TransferringType
    {
        Upload,
        Download
    }
}
