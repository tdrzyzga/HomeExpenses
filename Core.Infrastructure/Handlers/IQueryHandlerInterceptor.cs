using Core.Message.Queries;
using MediatR;
using System.Threading.Tasks;

namespace Core.Infrastructure.Handlers
{
    public interface IQueryHandlerInterceptor<in TQuery, TQueryResult> : IRequestHandler<TQuery, IQueryResult>
        where TQuery : IQuery
        where TQueryResult : IQueryResult
    {
    }
}