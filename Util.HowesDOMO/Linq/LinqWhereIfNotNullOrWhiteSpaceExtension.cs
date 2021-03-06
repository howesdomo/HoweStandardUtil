﻿using System.Collections.Generic;
using System.Linq.Expressions;

namespace System.Linq
{
    /// <summary>
    /// Linq Where查询条件的扩展
    /// 
    /// if(a.HasValue == true)
    /// result = source.Where(p => p.Qty.CompareTo(argQty.Value) == 0);
    /// 
    /// 对于这样的条件我们使用本扩展进行编写, 增强代码易读性
    /// .WhereIfHasValue(condition, p => p.Name.Contains(name))
    /// </summary>
    public static class LinqWhereIfNotNullOrWhiteSpaceExtension
    {
        public static IQueryable<T> WhereIfNullOrWhiteSpace<T>(this IQueryable<T> source, string condition, Expression<Func<T, bool>> predicate)
        {
            return string.IsNullOrWhiteSpace(condition) == false ? source.Where(predicate) : source;
        }

        public static IEnumerable<T> WhereIfNullOrWhiteSpace<T>(this IEnumerable<T> source, string condition, Func<T, bool> predicate)
        {
            return string.IsNullOrWhiteSpace(condition) == false ? source.Where(predicate) : source;
        }
    }
}
