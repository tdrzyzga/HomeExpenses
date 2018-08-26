using System;

namespace Core.Message.Commands
{
    public class ValidationErrorResponse : CommandErrorResponse
    {
        public ValidationErrorResponse(Guid errorId, ErrorItem[] errors = null)
            : base(errorId, null, errors)
        {
        }
    }
}