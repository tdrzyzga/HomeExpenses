using Core.Message.Queries;
using MediatR;

namespace Core.Presentation.Handlers
{
    public interface IQueryHandlerInterceptor<in TQuery> : IRequestHandler<TQuery, IQueryResult> where TQuery : class, IQuery
    {
    }
}