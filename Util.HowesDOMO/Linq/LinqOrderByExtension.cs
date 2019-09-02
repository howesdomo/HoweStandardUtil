using System.Collections.Generic;


namespace System.Linq
{
    public static class LinqOrderByExtension
    {
        #region Order By Random - 随机排序

        public static IQueryable<T> OrderByRandom<T>(this IQueryable<T> source)
        {
            return source.OrderBy(x => Guid.NewGuid());
        }

        public static IEnumerable<T> OrderByRandom<T>(this IEnumerable<T> source)
        {
            return source.OrderBy(x => Guid.NewGuid());
        }

        // 用 OrderBy(x => Guid.NewGuid()) 这个方法来实现, 思路更佳简洁稳定
        // 故不再采用以下的代码进行随机排序
        //public static IOrderedEnumerable<T> OrderByRandom<T>(this IQueryable<T> args)
        //{
        //    List<T> list = args.ToList();

        //    Random rand = new Random();

        //    int len = list.Count();
        //    for (var i = 0; i < len - 1; i++)
        //    {
        //        int index = rand.Next(len);
        //        T temp = list.ElementAt(index);
        //        list[index] = list[len - i - 1];
        //        list[len - i - 1] = temp;
        //    }

        //    return (IOrderedEnumerable<T>)list;
        //}

        //public static IOrderedEnumerable<T> OrderByRandom2<T>(this List<T> args)
        //{
        //    List<T> list = args;

        //    Random rand = new Random();

        //    int len = list.Count();
        //    for (var i = 0; i < len - 1; i++)
        //    {
        //        int index = rand.Next(len);
        //        T temp = list.ElementAt(index);
        //        list[index] = list[len - i - 1];
        //        list[len - i - 1] = temp;
        //    }

        //    return (IOrderedEnumerable<T>)list;
        //}

        #endregion


    }
}
