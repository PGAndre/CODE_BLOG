using System;
using System.Globalization;

namespace _14_Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            int u = 5;
            try
            {
                throw new MyOwnException("hello my excepton");
                var i = 5;
                var j = i / 1;
                Console.WriteLine(j);

                throw new DivideByZeroException("jhghgjh"); //  можно вставить message
                int a = 20000000;
                int b = 20000000;
                int c = checked(a * b);
                Console.WriteLine(c);

                //throw new Exception();
                
            }
            catch (MyOwnException ex)
            {
                Console.WriteLine(ex.Message);
            }
            
            catch (DivideByZeroException ex) when ( u == 5) //дополнительное условие для отработки исключения.
            {
                Console.WriteLine("Деление на ноль");
                //throw; //бросить исклчение дальше
            }
            catch (Exception e)
            {
                Console.WriteLine("просто исключение");
                Console.WriteLine(e.Message);
            }


            finally
            {
                Console.WriteLine("Работа завершена");
                Console.ReadLine();
            }

            
        }
    }
}
