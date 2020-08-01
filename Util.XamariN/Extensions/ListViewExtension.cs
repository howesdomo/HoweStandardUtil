using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Xamarin.Forms
{
    public static class ListViewExtension
    {
        public static List<ViewCell> GetViewCells(this ListView listView)
        {
            IEnumerable<PropertyInfo> pInfos = (listView as ItemsView<Cell>).GetType().GetRuntimeProperties();

            var templatedItems = pInfos.FirstOrDefault(info => info.Name == "TemplatedItems");
            if (templatedItems == null)
            {
                throw new Exception("无法获取 Xamarin.Forms.ListView 内的所有 ViewCell 集合");
            }

            var cells = templatedItems.GetValue(listView);
            if (cells == null)
            {
                return null;
            }

            return (cells as Xamarin.Forms.ITemplatedItemsList<Xamarin.Forms.Cell>).Select(i => i as ViewCell).ToList();
        }
    }
}
