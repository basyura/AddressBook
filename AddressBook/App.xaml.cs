using System;
using System.Runtime.InteropServices;

using System.Windows;
using System.Windows.Threading;

namespace AddressBook
{
    /// <summary>
    /// App.xaml の相互作用ロジック
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            this.DispatcherUnhandledException += Application_DispatcherUnhandledException;
            base.OnStartup(e);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void Application_DispatcherUnhandledException(object sender, DispatcherUnhandledExceptionEventArgs e)
        {
            if (e.Exception is COMException comException && comException.ErrorCode == -2147221040)
            {
                e.Handled = true;
            }
        }
    }
}
