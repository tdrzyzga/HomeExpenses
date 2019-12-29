using Core.Message.Queries;
using MediatR;

namespace Core.Presentation.Handlers
{
    public interface IQueryHandlerInterceptor<TQuery, TQueryResult> : IRequestHandler<TQuery, IQueryResult>
        where TQuery : class, IQuery
        where TQueryResult : class, IQueryResult
    {
    }
}