using System.Collections.Generic;
using System.Linq.Expressions;

namespace System.Linq
{
    /// <summary>
    /// Linq Where查询条件的扩展
    /// 
    /// if(string.IsNullOrEmpty(name) == false)
    /// result = source.Where(p => p.Name.Contains(name));
    /// 
    /// 对于这样的条件我们使用本扩展进行编写, 增强代码易读性
    /// .WhereIfNotNullOrEmpty(name, p => p.Name.Contains(name))
    /// </summary>
    public static class LinqWhereIfNotNullOrEmptyExtension
    {
        public static IQueryable<T> WhereIfNotNullOrEmpty<T>(this IQueryable<T> source, string condition, Expression<Func<T, bool>> predicate)
        {
            return string.IsNullOrEmpty(condition) == false ? source.Where(predicate) : source;
        }

        public static IEnumerable<T> WhereIfNotNullOrEmpty<T>(this IEnumerable<T> source, string condition, Func<T, bool> predicate)
        {
            return string.IsNullOrEmpty(condition) == false ? source.Where(predicate) : source;
        }
    }
}
