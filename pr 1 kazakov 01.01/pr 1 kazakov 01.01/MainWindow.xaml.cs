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
using Lib_7;

namespace pr_1_kazakov_01._01
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Calculate calculate = new();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void StartCalc_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int n = Int32.Parse(InputN.Text);
                string result = calculate.GetSum(n);
                CalcOutput.Text = result;
            }
            catch (Exception)
            {
                MessageBox.Show("Проверьте введенное значение", "Ошибка");
            }
        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            InputN.Clear();
            CalcOutput.Clear();
        }

        private void About_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Практическая работа №1\n" +
                "Казаков Андрей ИСП-34\n" +
                "Найти сумму n целых, случайных чисел (ДСЧ), распределенных в диапазоне от 0 до n и меньше n / 2. " +
                "Вывести на экран на одной строке сгенерированные числа, на другой строке результат.", "О программе", MessageBoxButton.OK);
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
