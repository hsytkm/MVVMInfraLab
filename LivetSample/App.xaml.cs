﻿using System.Windows;

namespace LivetSample
{
    /// <summary>
    /// App.xaml の相互作用ロジック
    /// </summary>
    public partial class App : Application
    {
        private void Application_Startup(object sender, StartupEventArgs e)
        {
            Livet.DispatcherHelper.UIDispatcher = Dispatcher;
        }
    }
}
