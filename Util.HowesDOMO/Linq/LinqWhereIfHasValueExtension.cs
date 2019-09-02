using System.Collections.Generic;
using System.Linq.Expressions;

namespace System.Linq
{
    /// <summary>
    /// Linq Where查询条件的扩展
    /// 
    /// if(argQty.HasValue == true)
    /// result = source.Where(p => p.Qty.CompareTo(argQty.Value) == 0);
    /// 
    /// 对于这样的条件我们使用本扩展进行编写, 增强代码易读性
    /// .WhereIfHasValue(condition, p => p.Name.Contains(name))
    /// </summary>
    public static class LinqWhereIfHasValueExtension
    {
        public static IQueryable<T> WhereIfHasValue<T>(this IQueryable<T> source, bool? condition, Expression<Func<T, bool>> predicate)
        {
            return condition.HasValue ? source.Where(predicate) : source;
        }

        public static IEnumerable<T> WhereIfHasValue<T>(this IEnumerable<T> source, bool? condition, Func<T, bool> predicate)
        {
            return condition.HasValue ? source.Where(predicate) : source;
        }

        public static IQueryable<T> WhereIfHasValue<T>(this IQueryable<T> source, int? condition, Expression<Func<T, bool>> predicate)
        {
            return condition.HasValue ? source.Where(predicate) : source;
        }

        public static IEnumerable<T> WhereIfHasValue<T>(this IEnumerable<T> source, int? condition, Func<T, bool> predicate)
        {
            return condition.HasValue ? source.Where(predicate) : source;
        }

        public static IQueryable<T> WhereIfHasValue<T>(this IQueryable<T> source, long? condition, Expression<Func<T, bool>> predicate)
        {
            return condition.HasValue ? source.Where(predicate) : source;
        }

        public static IEnumerable<T> WhereIfHasValue<T>(this IEnumerable<T> source, long? condition, Func<T, bool> predicate)
        {
            return condition.HasValue ? source.Where(predicate) : source;
        }

        public static IQueryable<T> WhereIfHasValue<T>(this IQueryable<T> source, double? condition, Expression<Func<T, bool>> predicate)
        {
            return condition.HasValue ? source.Where(predicate) : source;
        }

        public static IEnumerable<T> WhereIfHasValue<T>(this IEnumerable<T> source, double? condition, Func<T, bool> predicate)
        {
            return condition.HasValue ? source.Where(predicate) : source;
        }

        public static IQueryable<T> WhereIfHasValue<T>(this IQueryable<T> source, decimal? condition, Expression<Func<T, bool>> predicate)
        {
            return condition.HasValue ? source.Where(predicate) : source;
        }

        public static IEnumerable<T> WhereIfHasValue<T>(this IEnumerable<T> source, decimal? condition, Func<T, bool> predicate)
        {
            return condition.HasValue ? source.Where(predicate) : source;
        }

        public static IQueryable<T> WhereIfHasValue<T>(this IQueryable<T> source, DateTime? condition, Expression<Func<T, bool>> predicate)
        {
            return condition.HasValue ? source.Where(predicate) : source;
        }

        public static IEnumerable<T> WhereIfHasValue<T>(this IEnumerable<T> source, DateTime? condition, Func<T, bool> predicate)
        {
            return condition.HasValue ? source.Where(predicate) : source;
        }

    }
}
