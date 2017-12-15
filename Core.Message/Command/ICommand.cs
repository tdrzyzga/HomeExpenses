using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Message.Command
{
    public interface ICommand
    {
        Metadata Metadata { get; }

        void SetMetadata(Metadata metadata);
    }
}
