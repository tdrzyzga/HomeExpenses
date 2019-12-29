using Core.Message.Queries;
using System.Threading.Tasks;

namespace Core.Presentation.Handlers
{
    public interface IQueryHandler
    {
    }

    public interface IQueryHandler<in TQuery> : IQueryHandler where TQuery : class, IQuery
    {
        Task<IQueryResult> Handle(TQuery query);
    }
}
