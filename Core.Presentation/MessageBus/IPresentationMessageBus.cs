using Core.Message.Queries;
using System.Threading.Tasks;

namespace Core.Presentation.MessageBus
{
    public interface IPresentationMessageBus
    {
        Task<IQueryResult> SendQuery<TQuery, TQueryResult>(TQuery query)
            where TQuery : class, IQuery
            where TQueryResult : class, IQueryResult;
    }
}