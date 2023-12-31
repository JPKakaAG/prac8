﻿using System;
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
            string a1, b1, c1, a2, b2, c2;

            Father father = new Father(tbf.Text);
            string userInput1 = tbc1.Text;
            string userInput2 = tbc2.Text;
            string[] nameArray1 = userInput1.Split(' ');
            string[] nameArray2 = userInput2.Split(' ');
            a1 = nameArray1[1];
            b1 = nameArray1[0];
            c1 = nameArray1[2];
            a2 = nameArray2[1];
            b2 = nameArray2[0];
            c2 = nameArray2[2];
            Child child1 = new Child(a1, b1, c1, father);
            Child child2 = new Child(a2, b2, c2, father);

            // Вызываем методы объектов
            tbRes.Text = $"Первый ребёнок:\r\n{child1.Print()}\r\nВторой ребёнок \r\n {child2.Print()}";
            child1.Print();
            child2.Print();
        }

        private void btnClon_Click(object sender, RoutedEventArgs e)
        {
            string a1, b1, c1, a2, b2, c2;

            Father father = new Father(tbf.Text);
            string userInput1 = tbc1.Text;
            string userInput2 = tbc2.Text;
            string[] nameArray1 = userInput1.Split(' ');
            string[] nameArray2 = userInput2.Split(' ');
            a1 = nameArray1[0];
            b1 = nameArray1[1];
            c1 = nameArray1[2];
            a2 = nameArray2[0];
            b2 = nameArray2[1];
            c2 = nameArray2[2];
            Child child1 = new Child(a1, b1, c1, father);
            Child child2 = new Child(a2, b2, c2, father);

            // Выполняем клонирование объекта
            Child childClone = (Child)child1.Clone();
            tbRes3.Text = ($" Клон:\r\n {childClone.Print()}");
        }

        private void btnSrav_Click(object sender, RoutedEventArgs e)
        {
            string a1,b1,c1,a2,b2,c2;

            Father father = new Father(tbf.Text);
            string userInput1 = tbc1.Text;
            string userInput2 = tbc2.Text;
            string[] nameArray1 = userInput1.Split(' ');
            string[] nameArray2 = userInput2.Split(' ');
            a1 = nameArray1[0];
            b1 = nameArray1[1];
            c1 = nameArray1[2];
            a2 = nameArray2[0];
            b2 = nameArray2[1];
            c2 = nameArray2[2];
            Child child1 = new Child(a1,b1,c1, father);
            Child child2 = new Child(a2,b2,c2, father);

            // Выполняем сравнение объектов
            int result = child1.CompareTo(child2);
            string comparisonResult = result == 0 ? "равны" : result < 0 ? "меньше" : "больше";
            tbRes2.Text = ("Сравнение:\r\n " + child1.Name + " и " + child2.Name + " - " + comparisonResult);
        }
    }
}
