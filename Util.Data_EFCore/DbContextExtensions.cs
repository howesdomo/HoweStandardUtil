using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection;

namespace Microsoft.EntityFrameworkCore
{
    /// <summary>
    /// DbContext 扩展方法整理代码
    /// 
    /// V 1.0.0 - 2021-03-16 11:29:19
    /// 首次从 SecuritySolution 整理到 Util.Data_EFCore 中
    /// </summary>
    public static class DbContextExtensions
    {
        /// <summary>
        /// 从数据库中获取表内字段信息
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        public static List<PropertyInfo> GetDbSetProperties(this DbContext context)
        {
            var dbSetProperties = new List<PropertyInfo>();
            var properties = context.GetType().GetProperties();

            foreach (var property in properties)
            {
                var setType = property.PropertyType;
                var isDbSet = setType.IsGenericType && (typeof(DbSet<>).IsAssignableFrom(setType.GetGenericTypeDefinition()) || setType.GetInterface(typeof(DbSet<>).FullName) != null);
                if (isDbSet)
                {
                    dbSetProperties.Add(property);
                }
            }

            return dbSetProperties;
        }

        public static void UpdateTableColDescriptions(this DbContext context)
        {
            new Util.Data_EFCore.TableColDescriptionsUtils().UpdateTableColDescriptions(context);
        }
    }
}
