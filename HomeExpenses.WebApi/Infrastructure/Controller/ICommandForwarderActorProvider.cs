using System.Threading.Tasks;
using Core.Message.Commands;

namespace HomeExpenses.WebApi.Infrastructure.Controller
{
    public interface ICommandForwarderActorProvider
    {
        Task<object> Ask<TCommand>(TCommand command) where TCommand : ICommand;
    }
}