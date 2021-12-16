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

namespace pr_8_kazakov_01._01
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Rectangle rectangle = new();
        Circle circle = new();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void getCircleArea_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double radius = Convert.ToDouble(inputCircleR.Text);
                circleAreaOutput.Text = circle.GetCircleArea(radius).ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Проверьте введенный значения", "Ошибка");
            }
        }

        private void getCirclePerimeter_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double radius = Convert.ToDouble(inputCircleR.Text);
                circlePerimeterOutput.Text = circle.GetCirclePerimeter(radius).ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Проверьте введенный значения", "Ошибка");
            }
        }

        private void getRectangleArea_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double a = Convert.ToDouble(inputRectangleA.Text);
                double b = Convert.ToDouble(inputRectangleB.Text);
                rectangleAreaOutput.Text = rectangle.GetRectangleArea(a, b).ToString();
            }
            catch
            {

                MessageBox.Show("Проверьте введенный значения", "Ошибка");
            }
        }

        private void getRectanglePerimeter_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double a = Convert.ToDouble(inputRectangleA.Text);
                double b = Convert.ToDouble(inputRectangleB.Text);
                rectanglePerimeterOutput.Text = rectangle.GetRectanglePerimeter(a, b).ToString();
            }
            catch
            {

                MessageBox.Show("Проверьте введенный значения", "Ошибка");
            }
        }

        private void compare_Click(object sender, RoutedEventArgs e)
        {
            if (circle.Area != 0 && rectangle.Area != 0)
            {
                if (circle.CompareTo(rectangle) == 1)
                    MessageBox.Show("Площадь круга больше площаи прямоугольника");
                if (circle.CompareTo(rectangle) == -1)
                    MessageBox.Show("Площадь прямоугольника больше площаи круга");
                if (circle.CompareTo(rectangle) == 0)
                    MessageBox.Show("Плошади фигур равны");
            }

            else MessageBox.Show("Рассчитайте площади двух фигур", "Ошибка");
        }

        private void about_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Практическая работа №8\n" +
                "Казаков Андрей ИСП-34\n" +
                "Создать интерфейс – фигура (площадь, периметр). Создать классы - прямоугольник, круг. " +
                "Классы должны включать конструкторы, функцию для формирования строки информации о фигуре. Сравнение производить по площади.", "О программе", MessageBoxButton.OK);
        }

        private void exit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
