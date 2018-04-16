namespace Core.Message.Command
{
    public interface ICommand
    {
        Metadata Metadata { get; }

        void SetMetadata(Metadata metadata);
    }
}