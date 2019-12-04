using System;
using System.Linq;
using System.Linq.Expressions;

namespace Core.Presentation.Pagination
{
    public interface ISortExpression<T> where T : class
    {
        Expression<Func<T, object>> GetSortExpression(string sortBy);
        IQueryable<T> SortBy(IQueryable<T> query, string sortBy, SortDirection sortDir);
    }
}