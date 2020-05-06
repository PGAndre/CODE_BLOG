using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _29_object
{
    class Point
    {
        public int X { get; set; }

        public override bool Equals(object obj) //внимание - принмает любой тип ,а не только Point
                                                //правила переопределения Equals 
                                                //1. методе не должен выкидывать Exceptions (Null)
                                                //2. a=a
                                                //3. (a=b, b=c) => a=c
                                                //4. переопределяя equals -> переопрелели и оператор "="
        {
            return base.Equals(obj);
            {
                // if (obj == null) return false; - так же не нужно, тк if покрывает проверку на null

                //приводим к исходному типу Poing, чтобы не сравнивать "сладкое с зеленым".

                // as делает попытку преобразования к типу ,если не удается - то null.
                if (obj is Point point)
                {
                    return this.X == point.X; // сравниваем значения полей для объектов, а не адреса ссылок в памяти.
                }
                else
                {
                    return false;
                }



            }

        }
        //GetHashCode() //должна быть быстрой. если Хэшкоды разные - то это точно разные обхекты. Но если одинаковые, то не факт, что один объект
        public override int GetHashCode()
        {
            return X;
        }

    }
}
