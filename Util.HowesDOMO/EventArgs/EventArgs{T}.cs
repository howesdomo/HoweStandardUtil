namespace System
{
    /// <summary>
    /// V 1.0.0 - 2020-1-3 17:08:37
    /// 首次创建 - 新引入 EventArgs<T>, 懒人的福音, 不用再去创建EventArgs的新的继承类
    /// </summary>
    /// <typeparam name="T">Type of the argument</typeparam>
    public class EventArgs<T> : EventArgs
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EventArgs"/> class.
        /// </summary>
        /// <param name="value">Value of the argument</param>
        public EventArgs(T value)
        {
            this.Value = value;
        }

        /// <summary>
        /// Gets the value of the event argument
        /// </summary>
        public T Value { get; private set; }
    }
}