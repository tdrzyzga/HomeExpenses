using Core.Message.Queries;

namespace Core.Presentation.Handlers
{
    public interface IQueryHandlerInterceptor<TQuery, TQueryResult>
        where TQuery : class, IQuery
        where TQueryResult : class, IQueryResult
    {
    }
}