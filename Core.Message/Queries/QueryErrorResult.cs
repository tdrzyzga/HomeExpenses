﻿using System;

namespace Core.Message.Queries
{
    public class QueryErrorResult : IQueryResult
    {
        public Guid ErrorId { get; }
        public string Message { get; }
        public ErrorItem[] Errors { get; }

        public QueryErrorResult(Guid errorId, string message, ErrorItem[] errors = null)
        {
            ErrorId = errorId;
            Message = message;
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