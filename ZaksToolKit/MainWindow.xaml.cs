using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using ZaksToolKit.Tools;

namespace ZaksToolKit {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
        }

        private void btn_Click(object sender, RoutedEventArgs e) {
            MyLog.logger.Trace("点击按钮");
            MyLog.logger.Info("点击按钮");
            MyLog.logger.Debug("点击按钮");
            MyLog.logger.Warn("点击按钮");
            MyLog.logger.Error("点击按钮");
            MyLog.logger.Fatal("点击按钮");

        }
    }
}
