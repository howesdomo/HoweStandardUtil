using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace Util.UIComponent
{
    /// <summary>
    /// V 1.0.2 ( HoweStandardUtil 特有 ) - 2019-10-28 15:28:22
    /// 优化 PropertyChanged 代码, 加上 CallerMemberName( 允许您获取该方法的调用者方法或属性名称 )
    /// 
    /// V 1.0.1
    /// 简化 PropertyChanged 代码
    /// </summary>
    public abstract class VirtualModel : INotifyPropertyChanged
    {
        public VirtualModel()
        {
            this.PropertyChanged += new PropertyChangedEventHandler(SelfPropertyChanged);
        }

        protected virtual void SelfPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            return;
        }

        public virtual string DisplayName
        {
            get;
            private set;
        }

        #region Checked

        public virtual bool IsChecked
        {
            get;
            set;
        }

        public virtual bool IsOnCheck
        {
            get
            {
                return this.IsChecked;
            }
            set
            {
                if (this.IsChecked != value)
                {
                    this.IsChecked = value;
                    this.OnPropertyChanged("IsOnCheck");

                    this.CheckedItem = this.IsChecked ? this : null;
                }
            }
        }

        protected object _checkedItem;

        public virtual object CheckedItem
        {
            get
            {
                return this._checkedItem;
            }
            set
            {
                if (this._checkedItem != value)
                {
                    this._checkedItem = value;

                    this.OnPropertyChanged("CheckedItem");
                }
            }
        }

        #endregion

        #region Selected

        public virtual bool IsSelected
        {
            get;
            set;
        }

        public virtual bool IsOnSelect
        {
            get
            {
                return this.IsSelected;
            }
            set
            {
                if (this.IsSelected != value)
                {
                    this.IsSelected = value;
                    this.OnPropertyChanged("IsOnSelect");
                }
            }
        }

        #endregion

        #region Property Changed

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([System.Runtime.CompilerServices.CallerMemberName]string name = "")
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        protected void OnPropertyChanged(object sender, [System.Runtime.CompilerServices.CallerMemberName] string name = "")
        {
            this.PropertyChanged?.Invoke(sender, new PropertyChangedEventArgs(name));
        }

        #endregion

    }
}
