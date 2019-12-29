using Core.Message.Queries;

namespace Core.Application.Handlers
{
    public interface IQueryHandlerInterceptor<TQuery, TQueryResult>
        where TQuery : IQuery
        where TQueryResult : IQueryResult
    {
    }
}