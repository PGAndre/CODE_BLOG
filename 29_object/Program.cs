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
            Console.WriteLine(oj.GetHashCode()); //видит, что это int, запакованный в object. поэтому выдает значение 5.
            Console.WriteLine(p1.GetHashCode());

            Console.WriteLine(i.ToString());
            Console.WriteLine(p1.ToString());

            Console.WriteLine(i.GetType());
            Console.WriteLine(oi.GetType());
            Console.WriteLine(p1.GetType()); //Опасно замещать метод, а переопределять нельзя (не virtual).

            //typeof(Point) == p1.GetType();

            Console.WriteLine(typeof(Point));

            Console.WriteLine(Object.Equals(5, 5));
            Console.WriteLine(Object.ReferenceEquals(5, 5));
            Console.WriteLine(Object.ReferenceEquals(p2, p2));

            var pp = new Point() { X = 7, Y = new Point() };
            

            var pp2 = pp;            // ссылка на один и тот же объект. При изменении одного - будет изменяться и другой. Для создания нового объекта в другом участке памяти 
            //с новой ссылкой необходимо использовать клонирование.
            pp2.X = 77;
            var pp3 = pp.Clone();
            pp3.Y.X = 222;
            Console.WriteLine(pp3.Y.X);
            pp2.Y = new Point() { X = 99 };

            
            
            Console.WriteLine(pp3);
            Console.WriteLine(pp);

            





            Console.ReadLine();



            


        }

    }
}
