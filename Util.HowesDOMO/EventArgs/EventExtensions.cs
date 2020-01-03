namespace System
{
    /// <summary>
    /// V 1.0.0 - 2020-1-3 17:08:37
    /// 首次创建
    /// </summary>
    public static class EventExtensions
    {
        /// <summary>
        /// Raise the specified event.
        /// </summary>
        /// <param name="handler">Event handler.</param>
        /// <param name="sender">Sender object.</param>
        /// <param name="value">Argument value.</param>
        /// <typeparam name="T">The value type.</typeparam>
        public static void Invoke<T>(this EventHandler<EventArgs<T>> handler, object sender, T value)
        {
            handler?.Invoke(sender, new EventArgs<T>(value));
        }

        public static bool TryInvoke<T>(this EventHandler<T> handler, object sender, T args) where T : EventArgs
        {
            if (handler != null)
            {
                handler(sender, args);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}