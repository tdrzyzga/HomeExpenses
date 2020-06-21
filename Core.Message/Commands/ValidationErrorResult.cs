using System;

namespace Core.Message.Commands
{
    public class ValidationErrorResult : CommandErrorResult
    {
        public ValidationErrorResult(Guid errorId, ErrorItem[] errors = null)
            : base(errorId, null, errors)
        {
        }
    }
}