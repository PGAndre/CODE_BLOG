using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22_Indexers_Iterators
{
    class Program
    {
        static void Main(string[] args)
        {
            var cars = new List<Car>()
            {
                new Car() {Name = "Ford", Number = "A001AA01"},
                new Car() {Name = "Lada", Number = "T007KK02"}
            };

            var parking = new Parking();
            
            foreach (var car in cars)
            {
                parking.Add(car);
            }

            foreach (var car in parking)
            {
                Console.WriteLine(car);
            }

            foreach (var num in parking.GetNumbers(10))
            {
                Console.WriteLine(num);
            }


            foreach (var name in parking.GetNames())
            {
                Console.WriteLine("Name:" + name);
            }

            Car SearchedCar = parking["A001AA01"];
            Console.WriteLine(SearchedCar.Name);
            SearchedCar = parking["A001AA02"];
            Console.WriteLine(SearchedCar?.Name);

            Console.WriteLine("Введите номер нового автомобиля");
            var a = Console.ReadLine();

            parking[1] = new Car() { Name = "Audi", Number = a };
            Console.WriteLine(parking[1]);

            //Console.WriteLine(parking._cars[0]);
            Console.Read();

        }
    }
}
