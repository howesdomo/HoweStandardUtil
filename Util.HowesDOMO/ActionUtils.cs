using System;

/// <summary>
/// V2 - 2020-2-19 16:04:06
/// 改进代码, 适合与 WinForm 与 WPF
/// 
/// V1 - 2020-2-14 18:03:42
/// 首次创建
/// </summary>
namespace Util.ActionUtils
{
    /// <summary>
    /// 连续的多次调用，在每个时间段的周期内只执行第一次处理过程。
    /// </summary>
    public class ThrottleAction
    {
        System.Timers.Timer mThrottleTimer;

        ///// <summary>
        /////  ( WPF适用 ) 即刻执行，执行之后，在指定时间内再次调用无效
        ///// </summary>
        ///// <param name="interval">不应期，这段时间内调用无效</param>
        ///// <param name="dispatcher">同步对象，一般为控件。 如不需同步可传null</param>
        //public void Throttle(double interval, Action action, System.Windows.Threading.Dispatcher dispatcher = null)
        //{
        //    System.Threading.Monitor.Enter(this);
        //    bool needExit = true;
        //    try
        //    {
        //        if (mThrottleTimer == null)
        //        {
        //            mThrottleTimer = new System.Timers.Timer(interval);
        //            mThrottleTimer.AutoReset = false;
        //            mThrottleTimer.Elapsed += (o, e) =>
        //            {
        //                mThrottleTimer.Stop();
        //                mThrottleTimer.Close();
        //                mThrottleTimer = null;
        //            };
        //            mThrottleTimer.Start();

        //            System.Threading.Monitor.Exit(this); // 已保证Timer成功创建, 可以将锁释放
        //            needExit = false;

        //            if (dispatcher != null && dispatcher.Thread.IsBackground == false) //这个过程不能锁
        //            {
        //                dispatcher.Invoke(action, null);
        //            }
        //            else
        //            {
        //                action();
        //            }
        //        }
        //    }
        //    finally
        //    {
        //        if (needExit)
        //        {
        //            System.Threading.Monitor.Exit(this);
        //        }
        //    }
        //}

        /// <summary>
        /// ( Winform 适用 ) 即刻执行，执行之后，在指定时间内再次调用无效
        /// </summary>
        /// <param name="syncInvoke">同步对象，一般为控件。 如不需同步可传null</param>
        public void Throttle(double interval, Action action, System.ComponentModel.ISynchronizeInvoke syncInvoke)
        {
            System.Threading.Monitor.Enter(this);
            bool needExit = true;
            try
            {
                if (mThrottleTimer == null)
                {
                    mThrottleTimer = new System.Timers.Timer(interval);
                    mThrottleTimer.AutoReset = false;
                    mThrottleTimer.Elapsed += (o, e) =>
                    {
                        mThrottleTimer.Stop();
                        mThrottleTimer.Close();
                        mThrottleTimer = null;
                    };

                    mThrottleTimer.Start();

                    System.Threading.Monitor.Exit(this); // 已保证Timer成功创建, 可以将锁释放
                    needExit = false;

                    if (syncInvoke != null && syncInvoke.InvokeRequired == true) //这个过程不能锁
                    {
                        syncInvoke.Invoke(action, null);
                    }
                    else
                    {
                        action();
                    }
                }
            }
            finally
            {
                if (needExit)
                {
                    System.Threading.Monitor.Exit(this);
                }
            }
        }
    }

    /// <summary>
    /// 连续的多次调用，只有在调用停止之后的一段时间(指定间隔时间)内不再调用，然后才执行一次处理过程。
    /// </summary>
    public class DebounceAction
    {
        System.Timers.Timer mDebounceTimer;

        ///// <summary>
        /////  ( WPF 适用 ) 延迟指定时间后执行。 在此期间如果再次调用，则重新计时
        ///// </summary>
        ///// <param name="dispatcher"></param>
        //public void Debounce(double interval, Action action, System.Windows.Threading.Dispatcher dispatcher = null)
        //{
        //    lock (this)
        //    {
        //        if (mDebounceTimer == null)
        //        {
        //            mDebounceTimer = new System.Timers.Timer(interval);
        //            mDebounceTimer.AutoReset = false;
        //            mDebounceTimer.Elapsed += (o, e) =>
        //            {
        //                mDebounceTimer.Stop();
        //                mDebounceTimer.Close();
        //                mDebounceTimer = null;

        //                if (dispatcher != null && dispatcher.Thread.IsBackground == false)
        //                {
        //                    dispatcher.Invoke(action, null);
        //                }
        //                else
        //                {
        //                    action.Invoke();
        //                }
        //            };
        //        }
        //        mDebounceTimer.Stop();
        //        mDebounceTimer.Start();
        //    }
        //}

        /// <summary>
        /// ( Winform 适用 ) 延迟指定时间后执行。 在此期间如果再次调用，则重新计时
        /// </summary>
        /// <param name="syncInvoke">同步对象，一般为控件。 如不需同步可传null</param>
        public void Debounce(double interval, Action action, System.ComponentModel.ISynchronizeInvoke syncInvoke)
        {
            lock (this)
            {
                if (mDebounceTimer == null)
                {
                    mDebounceTimer = new System.Timers.Timer(interval);
                    mDebounceTimer.AutoReset = false;
                    mDebounceTimer.Elapsed += (o, e) =>
                    {
                        mDebounceTimer.Stop();
                        mDebounceTimer.Close();
                        mDebounceTimer = null;

                        if (syncInvoke != null && syncInvoke.InvokeRequired == true)
                        {
                            syncInvoke.Invoke(action, null);
                        }
                        else
                        {
                            action.Invoke();
                        }
                    };
                }
                mDebounceTimer.Stop();
                mDebounceTimer.Start();
            }
        }
    }
}