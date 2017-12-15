using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Message.Command
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
