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

namespace DemoMainUi {
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e) {
            //根据需要可改成动态加载
            string s = this.txt_Time.Text;
            this.txt_Time.Text = string.Empty;
            string splist = "638";
            this.txt_Time.Inlines.Add(new Run(s.Substring(0, s.IndexOf(splist))));
            this.txt_Time.Inlines.Add(new Run(splist) { Foreground = Brushes.Red });
            this.txt_Time.Inlines.Add(new Run(s.Substring(s.IndexOf(splist) + 3)));
        }
    }
}
