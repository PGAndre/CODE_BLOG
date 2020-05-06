using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace _11_Operator_Reload
{
    public class Apple : Product
    {
        public Apple(string name, int calorie, int volume) : base(name, calorie, volume)
        {

        }

        static public Apple Add(Apple apple1, Apple apple2)
        {
            int calorie = (int)Math.Round(((apple1.Calorie + apple2.Calorie) / 2.0));
            var volume = apple1.Volume + apple2.Volume;
            var apple = new Apple("Яблоко", calorie, volume);
            return apple;
        }

        public static Apple operator +(Apple apple1, Apple apple2)
        {
            return Apple.Add(apple1,apple2);
        }
    }
}
