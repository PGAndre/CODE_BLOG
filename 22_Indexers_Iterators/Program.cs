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

            Car SearchedCar = parking["A001AA01"];
            Console.WriteLine(SearchedCar.Name);
            SearchedCar = parking["A001AA02"];
            Console.WriteLine(SearchedCar?.Name);


            //Console.WriteLine(parking._cars[0]);
            Console.Read();

        }
    }
}
