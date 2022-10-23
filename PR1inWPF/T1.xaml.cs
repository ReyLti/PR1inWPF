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
using System.Windows.Shapes;

namespace PR1inWPF
{
    /// <summary>
    /// Логика взаимодействия для T1.xaml
    /// </summary>
    public partial class T1 : Window
    {
        public T1()
        {
            InitializeComponent();
        }

        private void RichTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void btn_Answer_Click(object sender, RoutedEventArgs e)
        {
            tb_Output.Text = null;
            try
            {
                int.Parse(tb_Input.Text);
            }
            catch
            {
                MessageBox.Show("Введенные данные имели неверный формат");
                return;
            }
            string s = tb_Input.Text;
            if (s.Length != 4) { MessageBox.Show("Входные данные имели неверный формат");return; }
            int sum = 0; //сумма всех чисел
            int pr = 1;  //произведение всех чисел
            for (int i = 0; i < s.Length; i++)
            {
                int x = int.Parse(s[i].ToString());
                sum += x;
                pr *= x;
            }
            tb_Output.Text += "Сумма равна: " + sum.ToString() + "\n" + "Произведение равно: " + pr.ToString();
        }
    }
}
