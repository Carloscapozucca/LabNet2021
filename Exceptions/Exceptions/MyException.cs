using System;
using System.Collections.Generic;
using System.Text;

namespace Exceptions
{
    public class MyException : System.Exception
    {
        public MyException(string mensaje) : base(mensaje)
        {
            
        }

    }
}
