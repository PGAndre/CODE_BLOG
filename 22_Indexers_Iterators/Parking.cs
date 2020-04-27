using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace _22_Indexers_Iterators
{
    class Parking
    {

        private List<Car> _cars = new List<Car>();
        private const int MAX_CARS = 100;

        public int Count => _cars.Count; //быстрое св-во (только для чтения). МОжно объявить доступ к закрытому полю класса только для чтения.
                                         //без геттеров и сеттеров.
        public string Name { get; set }

        public int Add(Car car)
        {
            if (car == null)
            {
                throw new ArgumentNullException(nameof(car), "car is absent");
            }

            if (_cars.Count < MAX_CARS)
            {
                _cars.Add(car);
                return _cars.Count -1; //небезопасно (почему?)
            }
            return -1;
                   
        }

        public void GoOut(string number)
        {
            if (string.IsNullOrWhiteSpace(number))
            {
                throw 
            }
        }
        
    }
}
