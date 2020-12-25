using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace StuHubSystem.Repo.Extensions
{
    public static class QueryableExtensions
    {
        public static IQueryable<T> WhereIf<T>(this IQueryable<T> query, bool condition, Expression<Func<T, bool>> predicateIftrue)
            => condition ? query.Where(predicateIftrue) : query;
    }
}
