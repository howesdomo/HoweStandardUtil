using System;
using System.Collections.Generic;
using System.Text;

namespace System.Reflection
{
    public static class TypeExtension
    {
        /// <summary>
        /// 根据字段或属性名称返回字段或属性类型
        /// </summary>
        /// <param name="t">类型</param>
        /// <param name="fieldNameOrPropertyName">字段或属性名</param>
        /// <returns></returns>
        public static Type GetFieldTypeOrPropertyTypeByName(this Type t, string fieldNameOrPropertyName)
        {
            Type r;

            var p = t.GetProperty(fieldNameOrPropertyName);

            if (p != null)
            {
                r = p.PropertyType;
            }
            else
            {
                var f = t.GetField(fieldNameOrPropertyName);
                if (f != null)
                {
                    r = f.FieldType;
                }
                else
                {
                    throw new Exception("字段或属性不存在");
                }
            }

            return r;
        }
    }
}
