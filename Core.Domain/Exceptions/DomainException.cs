using System;

namespace Core.Domain.Exceptions
{
    public class DomainException : Exception
    {
        public string PublicMessage { get; }
        public ErrorItem[] Errors { get; }

        public DomainException(string message) : base(message)
        {
        }

        public DomainException(string message, string publicMessage, ErrorItem[] errors = null) : base(message)
        {
            PublicMessage = publicMessage;
            Errors = errors ?? new ErrorItem[0];
        }

        public class ErrorItem
        {
            public string Key { get; }
            public string Value { get; }

            public ErrorItem(string key, string value)
            {
                Key = key;
                Value = value;
            }
        }
    }
}