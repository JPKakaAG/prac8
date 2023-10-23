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

namespace WpfApp8
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

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnInfo_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Выполнил лучший разработчик: Девяткин Вадим Евгеньевич\r\nПрактическая №8\r\nСоздать интерфейс - человек, у которого есть имя, функция печати. \r\nСоздать класс" + 
                    "отец, у которого функция печати выводит имя.\r\nСоздать класс ребенок, у которого" +
                    "есть отец, отчество, функция печати выводит имя и отчество.Классы должны" +
                    "включать конструкторы.Сравнение производить по фамилии");
        }

        private void btnRes_Click(object sender, RoutedEventArgs e)
        {
            // Создаем объекты
            Father father = new Father("Иван");
            Child child1 = new Child("Петров Иван", "Иванович", father);
            Child child2 = new Child("Сидоров Петр", "Алексеевич", father);

            // Вызываем методы объектов
            child1.Print();
            child2.Print();

            // Выполняем сравнение объектов
            int result = child1.CompareTo(child2);
            string comparisonResult = result == 0 ? "равны" : result < 0 ? "меньше" : "больше";
            tbRes.Text = ("Сравнение: " + child1.Name + " и " + child2.Name + " - " + comparisonResult);

            // Выполняем клонирование объекта
            Child childClone = (Child)child1.Clone();
            childClone.Print();
        }
    }
}
