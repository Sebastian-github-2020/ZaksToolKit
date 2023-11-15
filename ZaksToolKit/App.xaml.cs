using NLog;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;


namespace ZaksToolKit {
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application {
        Logger logger = LogManager.GetCurrentClassLogger();
        protected override void OnStartup(StartupEventArgs e) {
            base.OnStartup(e);
            Console.WriteLine("OnStartup 启动");
            logger.Info("OnStartup 启动");
        }

        protected override void OnActivated(EventArgs e) {
            base.OnActivated(e);
            Console.WriteLine("OnActivated程序处于活动状态");
            logger.Info("OnActivated程序处于活动状态");
        }

        protected override void OnDeactivated(EventArgs e) {
            base.OnDeactivated(e);
            Console.WriteLine("OnDeactivated 程序处于最小化(非活动)状态");
            logger.Info("OnDeactivated 程序处于最小化(非活动)状态");
        }
        protected override void OnExit(ExitEventArgs e) {
            base.OnExit(e);
            Console.WriteLine("程序退出");
            logger.Info("OnDeactivated 程序处于最小化(非活动)状态");
        }
    }
}
