using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;

namespace System
{
    /// <summary>
    /// 排序方向    
    /// 
    /// V 1.0.0 - 2020-08-13 15:00:00
    /// 首次创建
    /// </summary>
    public enum SortDirection
    {
        Ascending = 0,
        Descending = 1
    }

    /// <summary>
    /// 动态排序基础类, 可以直接使用或者继承本类
    /// 
    /// V 1.0.1 - 2020-08-17 09:14:25
    /// 增加 排序比较器 属性
    /// 
    /// V 1.0.0 - 2020-08-13 15:00:00
    /// 首次创建
    /// </summary>
    public class DynamicSort
    {
        /// <summary>
        /// 排序方向
        /// </summary>
        public SortDirection SortingType { get; set; }

        /// <summary>
        /// 参与排序的字段或属性名称
        /// </summary>
        public string FieldNameOrPropertyName { get; set; }

        /// <summary>
        /// 排序比较器 ( 默认可空 )
        /// </summary>
        public Comparer<object> Comparer { get; set; }

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="fieldNameOrPropertyName">参与排序的字段或属性名称</param>
        /// <param name="sortingType">排序方向（默认升序）</param>
        public DynamicSort(string fieldNameOrPropertyName, SortDirection sortingType = SortDirection.Ascending)
        {
            this.FieldNameOrPropertyName = fieldNameOrPropertyName;
            this.SortingType = sortingType;
        }
    }
}

namespace System.Linq
{
    /// <summary>
    /// 动态排序
    /// 
    /// V 1.0.0 - 2020-08-13 15:00:00
    /// 首次创建
    /// </summary>
    public static class LinqDynamicSortByExtension
    {
        /// <summary>
        /// 动态排序
        /// </summary>
        /// <typeparam name="T">集合泛型</typeparam>
        /// <param name="l">排序集合</param>
        /// <param name="sortPropList">排序依据集合</param>
        /// <returns>返回排序好的 IQueryable 对象</returns>
        public static IQueryable SortBy<T>(this IEnumerable<T> l, List<DynamicSort> sortPropList)
        {
            var q = l.AsQueryable();
            Expression exp = q.Expression;

            Type genericType = typeof(T);
            var parameterExp = Expression.Parameter(genericType, "x"); // lambda step 1 : x        ( 标记类型 T ==> x )

            string whatBy = "OrderBy"; // 首次为 OrderBy, 其余都是 ThenBy

            foreach (DynamicSort item in sortPropList)
            {
                string name = item.FieldNameOrPropertyName;

                var memberExp = Expression.PropertyOrField(parameterExp, name); // lambda step 2 : x.Name       ( 找出类型 T 的字段或属性 x.Name )
                var lambda = Expression.Lambda(memberExp, parameterExp); // lambda step 3 : x => x.Name         ( 组合成 lambda 表达式 )

                Type fieldOrPropertyType = genericType.GetFieldTypeOrPropertyTypeByName(name);

                if (item.Comparer == null)
                {
                    exp = Expression.Call
                    (
                        typeof(Queryable),
                        item.SortingType == SortDirection.Ascending ? $"{whatBy}" : $"{whatBy}Descending",
                        new Type[] { genericType, fieldOrPropertyType },
                        exp,
                        lambda
                    );
                }
                else
                {
                    exp = Expression.Call
                    (
                        typeof(Queryable),
                        item.SortingType == SortDirection.Ascending ? $"{whatBy}" : $"{whatBy}Descending",
                        new Type[] { genericType, fieldOrPropertyType },
                        exp,
                        lambda,
                        Expression.New(item.Comparer.GetType())
                    );
                }

                whatBy = "ThenBy"; // 首次为 OrderBy, 其余都是 ThenBy
            }

            return q.Provider.CreateQuery(exp);
        }
    }
}

