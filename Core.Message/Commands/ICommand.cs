namespace Core.Message.Commands
{
    public interface ICommand
    {
        Metadata Metadata { get; }

        void SetMetadata(Metadata metadata);
    }
}