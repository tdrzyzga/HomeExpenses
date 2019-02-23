using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Core.Domain.Entities;

namespace Core.Presentation.Pagination
{
    public class SortExpression<TAggregateRoot> where TAggregateRoot : AggregateRoot
    {
        private readonly IDictionary<string, Expression<Func<TAggregateRoot, object>>> _sortExpressionDictionary =
            new Dictionary<string, Expression<Func<TAggregateRoot, object>>>();

        private Expression<Func<TAggregateRoot, object>> _defaultSortBy = x => x.Id.ToString();
        private SortDirection _defaultSortDir = SortDirection.Asc;

        public Expression<Func<TAggregateRoot, object>> GetSortExpression(string sortBy)
        {
            if (!string.IsNullOrWhiteSpace(sortBy) && _sortExpressionDictionary.TryGetValue(sortBy.ToLower(), out var result))
            {
                return result;
            }

            return _defaultSortBy;
        }

        public IQueryable<TAggregateRoot> SortBy(IQueryable<TAggregateRoot> query, string sortBy, SortDirection sortDir)
        {
            if (sortDir == SortDirection.None)
                sortDir = _defaultSortDir;

            switch (sortDir)
            {
                case SortDirection.Asc:
                    return query.OrderBy(GetSortExpression(sortBy));
                case SortDirection.Desc:
                    return query.OrderByDescending(GetSortExpression(sortBy));
                default:
                    return query;
            }
        }


        public void AddEntry(string sortBy, Expression<Func<TAggregateRoot, object>> sortExpression)
        {
            _sortExpressionDictionary[sortBy.ToLower()] = sortExpression;
        }

        public void Default(Expression<Func<TAggregateRoot, object>> sortBy, SortDirection sortDir)
        {
            _defaultSortBy = sortBy;
            _defaultSortDir = sortDir;
        }
    }
}