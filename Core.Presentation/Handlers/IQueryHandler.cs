using Core.Message.Queries;
using System.Threading.Tasks;

namespace Core.Presentation.Handlers
{
    public interface IQueryHandler
    {
    }

    public interface IQueryHandler<in TQuery, TQueryResult> : IQueryHandler
        where TQuery : class, IQuery
        where TQueryResult : class, IQueryResult
    {
        Task<TQueryResult> Handle(TQuery query);
    }
}
