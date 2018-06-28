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

namespace WpfApp1
{
    /// <summary>
    /// MainWindow.xaml 的互動邏輯
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            marioPHOTO();
        }

        private void time_Loaded(object sender, RoutedEventArgs e)
        {
            
        }

        private void add_MouseDown(object sender, MouseButtonEventArgs e)
        {
            UserControl1 userControl = new UserControl1();
            list.Children.Add(userControl);
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            List<string> datas = new List<string>();
            foreach (UserControl1 item in list.Children)
            {
                string uuu = "";
                uuu += "|" + item.bbb + "|" + item.name;
                datas.Add(uuu);

            }
        }

        public void marioPHOTO()
        {
            BitmapImage mario = new BitmapImage();
            mario.UriSource =new Uri (@"C:\mario.jpg", UriKind.Relative);

            marioPTT.Source = mario;
        }
    }

    

}
