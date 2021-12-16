using System;
using System.Collections;
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

namespace pr_10_kazakov_01._01
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ArrayList numbers = new ArrayList();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void createArray_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int count = Int32.Parse(inputCount.Text);
                Random random = new();
                for (int i = 0; i < count; i++)
                {
                    numbers.Add(random.Next(-30, 101));
                    mainListBox.Items.Add(numbers[i]);
                }
                
            }
            catch
            {
                MessageBox.Show("Введите количество элементов", "Ошибка");
            }

        }


        private void about_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Практическая работа №10\n" +
                "Казаков Андрей ИСП-34\n" +
                "Дан массив в диапазоне [-30;100] найти минимальное и максимальное значение и обменять их местами.", "О программе", MessageBoxButton.OK);
        }

        private void exit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void minMaxChange_Click(object sender, RoutedEventArgs e)
        {
            if(numbers.Count != 0)
            {
                int min, max, temp, minIndex = 0, maxIndex = 0;
                max = Convert.ToInt32(numbers[0]);
                min = Convert.ToInt32(numbers[0]);
                for (int i = 0; i < numbers.Count; i++)
                {
                    if (Convert.ToInt32(numbers[i]) > max)
                    {
                        max = Convert.ToInt32(numbers[i]);
                        maxIndex = i;
                    }
                    if (Convert.ToInt32(numbers[i]) < min)
                    {
                        min = Convert.ToInt32(numbers[i]);
                        minIndex = i;

                    }
                }
                temp = max; max = min; min = temp;
                mainListBox.Items[maxIndex] = max;
                mainListBox.Items[minIndex] = min;
            }
            else MessageBox.Show("Создайте массив", "Ошибка");
        }
    }
}
