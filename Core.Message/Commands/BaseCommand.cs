﻿namespace Core.Message.Commands
{
    public abstract class BaseCommand : ICommand
    {
        public Metadata Metadata { get; set; }

        public virtual void SetMetadata(Metadata metadata)
        {
            Metadata = metadata;
        }
    }
}