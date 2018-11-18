using Core.Message.Queries;

namespace Core.Presentation.Actors
{
    public interface IQueryActor<TQuery> where TQuery : IQuery
    {
    }
}