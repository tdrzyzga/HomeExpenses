using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Core.Domain.Entity;
using Microsoft.EntityFrameworkCore;

namespace Core.Infrastructure.Database
{
    public static class DbSetExtensions
    {
        public static IQueryable<TEntity> IncludeAll<TEntity>(this DbSet<TEntity> dbSet) where TEntity : Entity
        {
            var includeChain = BuildChain(string.Empty, typeof(TEntity));

            var queryable = dbSet.AsQueryable();

            //return includeChain.Aggregate(queryable, (current, includeChainElement) => current.Include(includeChainElement));

            foreach (var includeChainElement in includeChain)
            {
                queryable = queryable.Include(includeChainElement);
            }

            return queryable;
        }

        // No comments. Hope "LazyLoading" will be implemented soon...
        public static List<string> BuildChain(string baseTypeName, Type type, Type declaringType = null)
        {
            var allPropertyInfos = type.GetProperties(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
            var allPropertiesToInclude = allPropertyInfos.Where(p => p.PropertyType.IsClass && p.PropertyType != typeof(string) ||
                                                                     p.PropertyType.IsGenericType && p.PropertyType.GetGenericTypeDefinition() == typeof(ICollection<>))
                                                         .ToArray();

            var result = new List<string>();

            foreach (var propertyToInclude in allPropertiesToInclude)
            {
                var thisChain = $"{baseTypeName}.{propertyToInclude.Name}".Trim('.');
                result.Add(thisChain);


                var propertyType = propertyToInclude.PropertyType;

                if (propertyType.IsGenericType && propertyType.GetGenericTypeDefinition() == typeof(ICollection<>))
                {
                    propertyType = propertyType.GenericTypeArguments.First();
                }

                if (propertyType.IsClass && propertyType != declaringType)
                {
                    result.AddRange(BuildChain(thisChain, propertyType, type));
                }
            }

            return result;
        }
    }
}