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
    /// Логика взаимодействия для T3.xaml
    /// </summary>
    public partial class T3 : Window
    {
        public T3()
        {
            InitializeComponent();
        }

        private void btn_Answer_Click(object sender, RoutedEventArgs e)
        {
            tb_Output.Text = null;
            string[] s = tb_Input.Text.Split();
            string EvenNumbers = "Четные числа: "; //четные числа
            string Odd = "Нечетные числа: ";//нечетные числа
            for (int i = 0; i < s.Length; i++)
            {
                try
                {
                    int x = Convert.ToInt32(s[i]);
                    if (x % 2 == 0) EvenNumbers += s[i] + " ";
                    else Odd += s[i] + " ";
                }
                catch
                {
                    MessageBox.Show("Неверный формат данных");
                    return;
                }
            }
            tb_Output.Text += EvenNumbers + "\n" + Odd;
        }
    }
}
