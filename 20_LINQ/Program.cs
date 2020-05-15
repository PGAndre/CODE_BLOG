using System;
using System.Collections.Generic;
using System.Linq;

namespace _20_LINQ
{
    class Program
    {
        static Random rnd = new Random();
        static void Main(string[] args)
        {
            var collection = new List<int>();

            for (var i = 0; i < 10; i++)
            {
                collection.Add(i);
            }

            //для того чтобы собственный класс мог работать с LINQ необходимо чтобы он реализовал метод IEnumerable()
            var result = from item in collection
                         where item < 5
                         select item;

            var result2 = collection.Where(item => item < 5) //с помощью методов расширения
                .Where(item => item % 2 == 0)
                .OrderByDescending(item => item);

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();

            foreach (var item in result2)
            {
                Console.WriteLine(item);
            }
                       
            var collection2 = new List<Product>();
            for (var i = 0; i < 10; i++)
            {
                var product = new Product()
                {
                    Name = "Продукт" + i,
                    Energy = rnd.Next(10, 500)
                };
                collection2.Add(product);
            }

            var result3 = from item in collection2
                          where item.Energy > 100 && item.Energy <200
                          select item;

            foreach (var item in result3)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }

    }
}
