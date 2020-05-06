using System;
using System.Security.Cryptography.X509Certificates;

namespace _29_object
{
    class Program
    {
        static void Main(string[] args)
        {
            object obj = new object();

            //Equals

            int i = 5;
            int j = 5;

            i.Equals(j);

            //boxing- unboxing. boxing - поместить значимый объект в кучу. мы хотим работать с значимым объектом как с сылочным. например чтобы не указывать ref при 
            // передаче в метод. (не будет происходить клонирование объекта).

            Console.WriteLine(i.Equals(j));
            object oi = (object)i; //   
            var oj = (object)j;

            var p1 = new Point() { X = 5 };
            var p2 = new Point() { X = 5 };
            
            Console.WriteLine(oi.Equals(oj)); //.NET уменее чем кажется - оказалось True
            Console.WriteLine(p1.Equals(p2)); // вот тут всё ОК - false, хотя внутренности объета идентичны

            Console.WriteLine(new Class1().GetHashCode());
            Console.WriteLine(oj.GetHashode()); //видит, что это int, запакованный в object. поэтому выдает значение 5.
            Console.WriteLine(p1.GetHashCode());

            Console.ReadLine();

            


        }

    }
}
