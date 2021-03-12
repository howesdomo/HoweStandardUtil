using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace Util.UIComponent
{
    /// <summary>
    /// V 1.0.1 - 2021-02-22 17:14:00
    /// 修复 CollectionChanged 为 null 却执行通知事件
    /// 
    /// V 1.0.0 - 2021-01-28 17:00:00
    /// 首次创建
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class ObservableQueue<T> : Queue<T>, INotifyCollectionChanged
    {
        private int? _QueueMaxCapacity;
        /// <summary>
        /// 队列最大容量 ( 默认为空, 不设定最大容量 )
        /// </summary>
        public int? QueueMaxCapacity
        {
            get { return _QueueMaxCapacity; }
            set
            {
                _QueueMaxCapacity = value;
                fix();
            }
        }

        public ObservableQueue(int? maxCapacity = null)
        {
            QueueMaxCapacity = maxCapacity;
        }

        public ObservableQueue(int capacity, int? maxCapacity = null) : base(capacity)
        {
            QueueMaxCapacity = maxCapacity;
        }

        public ObservableQueue(IEnumerable<T> collection, int? maxCapacity = null) : base(collection)
        {
            QueueMaxCapacity = maxCapacity;
        }

        public event System.Collections.Specialized.NotifyCollectionChangedEventHandler CollectionChanged;

        public new void Clear()
        {
            base.Clear();
            if (this.CollectionChanged != null)
            {
                this.CollectionChanged(this, new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Reset));
            }
        }

        public new void Enqueue(T item)
        {
            base.Enqueue(item);
            fix();
            if (this.CollectionChanged != null)
            {
                this.CollectionChanged(this, new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Reset));
            }
        }

        public new T Dequeue()
        {
            T item = base.Dequeue();
            fix();
            if (this.CollectionChanged != null)
            {
                this.CollectionChanged(this, new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Reset));
            }
            return item;
        }

        /// <summary>
        /// 根据队列最大容量, 重新计算队列内的元素
        /// </summary>
        void fix()
        {
            if (QueueMaxCapacity.HasValue == false)
            {
                return;
            }

            // 被移出队列的数量 = 当前数量 - 最大容量
            int toDequeueCount = this.Count - QueueMaxCapacity.Value;
            if (toDequeueCount <= 0)
            {
                return;
            }

            for (int i = 0; i < toDequeueCount; i++)
            {
                base.Dequeue();
            }

            if (this.CollectionChanged != null)
            {
                this.CollectionChanged(this, new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Reset));
            }
        }
    }
}
