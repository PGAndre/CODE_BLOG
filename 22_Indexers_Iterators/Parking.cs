using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace _22_Indexers_Iterators
{
    class Parking : IEnumerable
    {

        private List<Car> _cars = new List<Car>();
        private const int MAX_CARS = 100;

        public Car this[string number]
        {
            get
            {
                var car = _cars.FirstOrDefault(c => c.Number == number);
                return car;
            }

        }

        public Car this[int position]
        {

            get
            {
                if (position < _cars.Count)
                { 
                    return _cars[position];
                }
                return null;
            }

            set
            {
                if (position < _cars.Count)
                {
                    _cars[position] = value;
                }
            }
        }

        public int Count => _cars.Count; //быстрое св-во (только для чтения). МОжно объявить доступ к закрытому полю класса только для чтения.
                                         //без геттеров и сеттеров.
        public string Name { get; set; }

        public int Add(Car car)
        {
            //if (car == null)
            //{
            //    throw new ArgumentNullException(nameof(car), "car is absent");
            //}

            if (_cars.Count < MAX_CARS)
            {
                _cars.Add(car);
                return _cars.Count -1; //небезопасно (почему?)
            }
            return -1;
                   
        }

        //автомобиль выехал
        public void GoOut(string number)
        {
            //if (string.IsNullOrWhiteSpace(number))
            //{
            //    throw new ArgumentNullException(nameof(number), "Number is null or empty");
            //}

            //Linq
            var car = _cars.FirstOrDefault(c => c.Number == number);  
            if(car !=null)
            {
                _cars.Remove(car);
            }    
        }


        public IEnumerable GetNumbers(int max)
        {
            var current = 0;
            for (int i = 0; i < max; i++)
            {
                current += i;
                yield return current;
            }
        }

        public IEnumerable GetNames()
        {
            foreach (var car in _cars)
            {
                yield return car.Name;
            }
        }


        public IEnumerator<Car> GetEnumerator() //просто IEnumerator Будет возвращать Object - не будут доступны св-ва объекта Car
        {
            return _cars.GetEnumerator();
        }

        //ienumerator ienumerable.getenumerator()
        //{
        //    return _cars.getenumerator();
        //}
    }

//    public class ParkingEnumerator : IEnumerator
//    {
//        public object Current => throw new NotImplementedException();

//        public bool MoveNext()
//        {
//            throw new NotImplementedException();
//        }

//        public void Reset()
//        {
//            throw new NotImplementedException();
//        }
//    }
}
