using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _11_Operator_Reload
{
    class Program
    {
        static void Main(string[] args)
        {
            Apple apple = new Apple("Красное яблоко", 50, 100);
            Apple apple2 = new Apple("зеленое яблоко", 40, 300);

            var SummApple = Apple.Add(apple, apple2);
            var SUmmApple2 = apple + apple2;
            var SummAppleInt = apple + 600;

            Console.WriteLine(apple);
            Console.WriteLine(apple2);
            Console.WriteLine(SummApple);
            Console.WriteLine(SUmmApple2);
            Console.WriteLine(SummAppleInt);
            Console.ReadLine();
        }

        

    }
}
