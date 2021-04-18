using System;
using System.Collections.Generic;
using System.Text;

namespace Exceptions
{
    public class Logic
    {
        public static void Exception (int c)
        {
            try
            {
                Console.Write("Ingrese un valor:");
                string linea = Console.ReadLine();
                var num = int.Parse(linea);
                var cuadrado = num * num;
                Console.WriteLine($"El cuadrado de {num} es {cuadrado}");
            }
            catch (FormatException)
            {
                Console.Write("Debe ingresar obligatoriamente un número entero.");
            }
        }
        private static void LanzaMyException()
        {
            throw new MyException("Lanzado");
        }

        public static void Exception (String c)
        {
            try
            {
                LanzaMyException();
            }
            catch (MyException ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }
    }
}
