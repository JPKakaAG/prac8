using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp8
{
    public interface IPerson
    {
        string Name { get; } // Свойство "Имя"
        string Print(); // Метод "Печать"
    }

    // Реализуем класс "Отец"
    public class Father : IPerson
    {
        public string Name { get; private set; } // Свойство "Имя"

        public Father(string name)
        {
            Name = name;
        }

        public string Print()
        {
            return  ("Имя: " + Name);
        }
    }

    // Реализуем класс "Ребенок"
    public class Child : IPerson, IComparable<Child>, ICloneable
    {
        public string Name { get; private set; } // Свойство "Имя"
        public string Surname { get; private set; } // Свойство "Фамилия"
        public string Patronymic { get; private set; } //Свойство "Отчество"
        public Father Father { get; private set; } // Свойство "Отец"

        public Child(string name, string surname, string patronymic, Father father)
        {
            Name = name;
            Surname = surname;
            Patronymic = patronymic;
            Father = father;
        }

        public string Print()
        {
            return("Имя: " + Name + ",\r\n Фамилия:" + Surname + ", \r\n Отчество: " + Patronymic);
        }

        // Реализуем метод сравнения по фамилии
        public int CompareTo(Child other)
        {
            if (other == null)
                return 1;

            string[] lastName1 = Name.Split(' ');
            string[] lastName2 = other.Name.Split(' ');

            return string.Compare(lastName1[0], lastName2[0], StringComparison.Ordinal);
        }

        // Реализуем метод клонирования
        public object Clone()
        {
            return new Child(Surname, Name, Patronymic, Father);
        }
    }

}
