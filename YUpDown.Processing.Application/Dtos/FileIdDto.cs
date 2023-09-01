namespace YUpDown.Processing.Application.Dtos
{
    public readonly struct FileIdDto
    {
        public readonly Guid Value;

        public FileIdDto(Guid value)
        {
            Value = value;
        }
    }
}
