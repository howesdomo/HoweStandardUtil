using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace Util.UIComponent
{
    public class BaseCollection<T> : ObservableCollection<T> where T : VirtualModel
    {
        #region Items Property Changed 集合内其中一个实体的属性(Prop)发生了改变

        public event PropertyChangedEventHandler ItemsPropertyChanged;

        protected virtual void OnItemsPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (this.ItemsPropertyChanged != null)
            {
                this.ItemsPropertyChanged(sender, e);
            }
        }

        protected virtual void ItemPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            this.OnItemsPropertyChanged(sender, e);
        }

        #endregion

        #region ( 重要 ) Add ：Add Item 时必须使用此方法，注册上事件

        public new void Add(T item)
        {
            item.PropertyChanged += new PropertyChangedEventHandler(ItemPropertyChanged);
            base.Add(item);
        }

        public void AddRange(IEnumerable<Util.UIComponent.VirtualModel> collection)
        {
            foreach (T item in collection)
            {
                this.Add(item);
            }
        }

        #endregion
    }
}
