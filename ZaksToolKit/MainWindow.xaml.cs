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
using ZaksTool;

namespace ZaksToolKit {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
            MyLog.logger.Info("主窗口启动");

        }
        /// <summary>
        /// 生成md5
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void makeMd5_Click(object sender, RoutedEventArgs e) {
            string md5SourceStr = this.Md5Txt.Text;
            if(md5SourceStr.Length > 0) {
                this.resultTxt.Text = ZaksTool.ZaksMd5.makeMd5(md5SourceStr, false);
            }
        }

        private void Md5Txt_GotFocus(object sender, RoutedEventArgs e) {
            MyLog.logger.Info("获得焦点");
            this.Md5Txt.Text = "";
            this.Md5Txt.Foreground = Brushes.Red;
        }

        private void Md5Txt_LostFocus(object sender, RoutedEventArgs e) {
            MyLog.logger.Info("丢失焦点");
        }
    }
}
