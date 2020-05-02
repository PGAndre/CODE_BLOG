using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_Exceptions
{
    class MyOwnException : Exception
    {
        public MyOwnException() : base("My Exception")
        {
        }

        public MyOwnException(string message) : base(message)
        {
        }
    }
}
