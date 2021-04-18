using System;
using System.Collections.Generic;
using System.Text;

namespace Exceptions
{
    public class DivisionPorCero
    {
        public static void ExceptionDivisionCero(int i, int j)
        {
            string resultado = "La operacion no fue exitosa";

            try
            {
                int division = i / j;
                resultado = "La operacion fue exitosa";
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine(resultado);

            }
        }

        public static int ExceptionDivisionCeroDos(int dividendo, int divisor)
        {
            int resultado = 0;
            try
            {
                Console.WriteLine("Introduzca un dividendo");
                dividendo = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine("Introduzca un divisor");
                divisor = Convert.ToInt16(Console.ReadLine());
                resultado = dividendo / divisor;
                Console.WriteLine("El resultado es :" + resultado);
                
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Solo Chuck Norris divide por cero!");
                Console.WriteLine(ex.Message);
            }
            catch (FormatException)
            {
                Console.WriteLine("Seguro ingreso una letra o no ingreso nada");               
            }
            finally
            {
                Console.WriteLine("Termino la operacion");
            }
            return resultado;

        }
    }
}
