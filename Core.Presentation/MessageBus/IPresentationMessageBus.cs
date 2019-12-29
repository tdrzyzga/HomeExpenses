using Core.Message.Queries;
using System.Threading.Tasks;

namespace Core.Presentation.MessageBus
{
    public interface IPresentationMessageBus
    {
        Task<IQueryResult> SendQuery<TQuery>(TQuery query) where TQuery : class, IQuery;
    }
}