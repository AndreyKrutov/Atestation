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
using SchoolSchedule;

namespace WpfApp
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<string> students = new List<string>() { "Иванов Иван", "Крутов Андрей", "Петров Алексей" };

        public MainWindow()
        {
            InitializeComponent();
            Spisok.ItemsSource = students;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Estimation cls = new Estimation();
                List<string> nygdejerychki = cls.GetMarks(DateTime.Now, students);

                Spisok.ItemsSource = nygdejerychki;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            //Random rnd = new Random();
            //string[] numbers = { (rnd.Next(2, 5)).ToString(), (rnd.Next(2, 5)).ToString(), (rnd.Next(2, 5)).ToString(), (rnd.Next(2, 5)).ToString(), (rnd.Next(2, 5)).ToString(), (rnd.Next(2, 5)).ToString(), (rnd.Next(2, 5)).ToString(), (rnd.Next(2, 5)).ToString(), (rnd.Next(2, 5)).ToString(), (rnd.Next(2, 5)).ToString()};
            //ArithmeticMean cls = new ArithmeticMean();
            //List<string> nygdejerychki = cls.MinAVG(numbers[]);
        }
    }
}
