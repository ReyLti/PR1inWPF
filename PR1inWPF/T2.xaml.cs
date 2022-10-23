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
    /// Логика взаимодействия для T2.xaml
    /// </summary>
    public partial class T2 : Window
    {
        public T2()
        {
            InitializeComponent();
        }
        string a = "абвгдежзийклмнопрстуфхцчшщъыьэюяАБВГДЕЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";
        private void btn_Answer_Click(object sender, RoutedEventArgs e)
        {
            tb_Output.Text = null;
            string s = tb_Input.Text;

            string answer = "";
            for (int i = 0; i < s.Length; i++)
            {
                switch (Check(s[i]))
                {
                    case 1:  answer += s[i]; break;
                    case 2:  answer += a[(a.IndexOf(s[i]) + 1)]; break;
                    case 3:  MessageBox.Show("Неверный формат данных"); return;
                }
            }
            tb_Output.Text = answer;
        }
        int Check(char c)
        {
            string s = " ,.!?:;ёЁ";
            if (s.Contains(c)) return 1;
            else
            {
                if (a.Contains(c)) return 2;
                else return 3;
            }

        }
    }
}
