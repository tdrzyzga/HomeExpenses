using Core.Message.Queries;
using Core.Presentation.Handlers;
using Microsoft.Extensions.Logging;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Core.Infrastructure.Handlers
{
    public class QueryHandlerInterceptor<TQuery> : IQueryHandlerInterceptor<TQuery> where TQuery : class, IQuery
    {
        private readonly IQueryHandler<TQuery> _handler;
        private readonly ILogger<QueryHandlerInterceptor<TQuery>> _logger;

        public QueryHandlerInterceptor(IQueryHandler<TQuery> handler, ILogger<QueryHandlerInterceptor<TQuery>> logger)
        {
            _handler = handler;
            _logger = logger;
        }

        public async Task<IQueryResult> Handle(TQuery query, CancellationToken cancellationToken = default)
        {
            try
            {
                _logger.LogDebug("Query {Query} successfuly handled.", query);

                return await _handler.Handle(query);
            }
            catch (Exception exception)
            {
                var errorId = Guid.NewGuid();

                _logger.LogError(exception, "Error occured during handling query {Query}", query);

                return new QueryErrorResult(errorId, "GENERAL ERROR");
            }
        }
    }
}
