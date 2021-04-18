using System;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ejercicio 1:");
            DivisionPorCero.ExceptionDivisionCero(4, 0);
            Console.WriteLine("Ejercicio 2:");
            DivisionPorCero.ExceptionDivisionCeroDos(8, 0);
            Console.WriteLine("Ejercicio 3:");
            Logic.Exception(4);
            Console.WriteLine("Ejercicio 4:");
            Logic.Exception("c");
            
        }
    }
}
