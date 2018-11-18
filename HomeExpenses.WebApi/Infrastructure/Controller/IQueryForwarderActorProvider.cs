using System.Threading.Tasks;
using Core.Message.Queries;

namespace HomeExpenses.WebApi.Infrastructure.Controller
{
    public interface IQueryForwarderActorProvider
    {
        Task<object> Ask<TQuery>(TQuery query) where TQuery : IQuery;
    }
}