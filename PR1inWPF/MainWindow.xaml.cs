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

namespace PR1inWPF
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn_first_Click(object sender, RoutedEventArgs e)
        {
            new T1().Show();
        }

        private void btn_second_Click(object sender, RoutedEventArgs e)
        {
            new T2().Show();
        }

        private void btn_third_Click(object sender, RoutedEventArgs e)
        {
            new T3().Show();
        }

        private void btn_fourth_Click(object sender, RoutedEventArgs e)
        {
            new T4().Show();
        }
    }
}
