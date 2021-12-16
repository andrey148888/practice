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
using System.Windows.Threading;

namespace pr_12_kazakov_01._01
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DispatcherTimer timer;
        RightTriangle triangle;
        Figure figure;

        public MainWindow()
        {
            InitializeComponent();
            timer = new DispatcherTimer();
            timer.Tick += Timer_Tick;
            timer.Interval = new TimeSpan(0, 0, 0, 0, 1);
            timer.IsEnabled = true;

        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            DateTime d = DateTime.Now;
            time.Text = d.ToString("HH:mm");
            date.Text = d.ToString("dd.MM.yyyy");
        }

        private void getHypotenuse_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                triangle = new();
                double a = Convert.ToDouble(inputA.Text);
                double b = Convert.ToDouble(inputB.Text);
                triangle.GetHypotenuse(a, b);
                hypotenuseOutput.Text = triangle.Hypotenuse.ToString();
            }
            catch
            {

                MessageBox.Show("Проверьте ввведенные значения", "Ошибка");
            }
        }

        private void getPerimeter_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                triangle = new();
                double a = Convert.ToDouble(inputA.Text);
                double b = Convert.ToDouble(inputB.Text);
                triangle.GetHypotenuse(a, b);
                triangle.GetPerimeter(a, b);
                perimeterOutput.Text = triangle.Perimeter.ToString();
            }
            catch
            {
                MessageBox.Show("Проверьте ввведенные значения", "Ошибка");
            }
        }

        private void about_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Практическая работа №12\n" +
                "Казаков Андрей ИСП-34\n" +
                "Реализовать расчет задачи: \n" +
                "Даны катеты прямоугольного треугольника a и b.Найти его гипотенузу c и периметр P.\n" +
                "Дано целое число, большее 999.Используя одну операцию деления нацело и одну операцию взятия остатка от деления, найти цифру, соответствующую разряду " +
                "сотен в записи этого числа.", "О программе", MessageBoxButton.OK);
        }

        private void exit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void getFigure_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int number = Int32.Parse(inputNumber.Text);
                if (number >= 999)
                {
                    figure = new Figure();
                    figureOutput.Text = figure.GetFigure(number).ToString();
                }
                else MessageBox.Show("Число должно быть больше 999", "Ошибка");
            }
            catch
            {
                MessageBox.Show("Проверьте введенное значение(целое число)", "Ошибка");
            }
        }
    }
}
