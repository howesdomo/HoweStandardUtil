using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace System.Linq
{
    /// <summary>
    /// V 1.0.1 - 2021-03-03 11:39:47
    /// 1 优化 CombineString 方法
    /// 2 增加 CombineStringWithSeq 方法
    /// </summary>
    public static class LinqToString
    {
        /// <summary>
        /// 连接集合字符
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="list">集合</param>
        /// <param name="symbol">分割符号(默认值 "; ")</param>
        /// <param name="isKeepLastSymbol">保留最后1个分割符号(默认值 否)</param>
        /// <returns></returns>
        public static string CombineString<T>(this IEnumerable<T> list, string symbol = "; ", bool isKeepLastSymbol = false)
        {
            string r = string.Join(symbol, list.Select(i => i.ToString()));

            if (isKeepLastSymbol == true) // 显示最后的信息的分隔符号
            {
                r += symbol;
            }

            return r;
        }

        /// <summary>
        /// <para>连接集合字符并且用序号将他们显示出来</para>
        /// <para>例如集合 ["A","B","C"]</para>
        /// <para>默认输出结果 1.A; 2.B; 3.C</para>
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="list">集合</param>
        /// <param name="symbol">分割符号(默认值 "; ")</param>
        /// <param name="isKeepLastSymbol">保留最后1个分割符号(默认值 否)</param>
        /// <param name="seqSymbol">序号后面的符号</param>
        /// <param name="isShowSeqEvenOnlyOneItem">集合只有一项也会显示序号(默认值 是)</param>
        /// <returns></returns>
        public static string CombineStringWithSeq<T>
        (
            this IEnumerable<T> list, 
            string symbol = "; ", 
            bool isKeepLastSymbol = false, 
            string seqSymbol = ".",
            bool isShowSeqEvenOnlyOneItem = true
        )
        {
            string r = string.Empty;

            if (list.Count() == 0) { return r; }

            StringBuilder sb = new StringBuilder();
            
            int count = list.Count();
            int seq = 1;
            
            foreach (T item in list)
            {
                if (count == 1 && isShowSeqEvenOnlyOneItem == false)
                {
                    sb.Append(item.ToString()).Append(symbol);                    
                }
                else
                {
                    sb.Append(seq).Append(seqSymbol).Append(item.ToString()).Append(symbol);
                    seq += 1;
                }
            }

            r = sb.ToString();
            if (isKeepLastSymbol == false) // 不保留最后一个符号
            {
                r = r.Substring(0, r.Length - symbol.Length);
            }

            return r;
        }
    }
}
