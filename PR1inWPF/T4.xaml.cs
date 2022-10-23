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
    /// Логика взаимодействия для T4.xaml
    /// </summary>
    public partial class T4 : Window
    {
        public T4()
        {
            InitializeComponent();
        }

        private void btn_Answer_Click(object sender, RoutedEventArgs e)
        {
            tb_Output.Text = null;
            string[] s = tb_Input.Text.Split();
            int Min, Max, MaxIndex, MinIndex;
            try { Min = int.Parse(s[0]); } catch { MessageBox.Show("Неверный формат данных"); return; }
            Max = Min;
            MaxIndex = 0;
            MinIndex = 0;
            for(int i = 0; i < s.Length; i++)
            {
                int x = 0;
                try
                {
                    x = Convert.ToInt32(s[i]);
                }
                catch
                {
                    MessageBox.Show("Неверный формат данных");
                    return;
                }
                if (x > Max)
                {
                    Max = x;
                    MaxIndex = i;
                }
                if (x < Min)
                {
                    Min = x;
                    MinIndex = i;
                }
            }
            if (MaxIndex > MinIndex)
            {
                for (int i = MinIndex+1, j = MaxIndex-1; j>i; i++,j--)
                {
                    string z = s[i];
                    s[i] = s[j];
                    s[j] = z;
                }
            }
            else
            {
                for (int i = MaxIndex + 1, j = MinIndex - 1; j > i; i++, j--)
                {
                    string z = s[i];
                    s[i] = s[j];
                    s[j] = z;
                }
            }
            tb_Output.Text = string.Join(" ",s);
        }
    }
}
