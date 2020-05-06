using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Operator_Reload
{
    public abstract class Product //нельзя сделать экземпляр абстрактного класса - нужно создать класс наследования (конкретный класс).
        // позволяет уменьшить дублирование кода.
    {
        public string Name { get; set; }

        public int Calorie { get; set; }

        public int Volume { get; set; }

        public Product(string name, int calorie, int volume) //Но может быть конструктор! чтобы все конкретные классы могли его использовать! у наследника должен быть конструктор 
            // с таким же набором параметров.
        {
             if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException(nameof(name));
            }
             if (calorie < 0)
            {
                throw new ArgumentException(nameof(calorie));
            }
             if (volume <= 0)
            {
                throw new ArgumentException(nameof(volume));
            }
            Name = name;
            Calorie = calorie;
            Volume = volume;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
