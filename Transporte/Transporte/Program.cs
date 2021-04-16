using System;
using System.Collections.Generic;

namespace Transporte
{
    class Program
    {
        static void Main(string[] args)
        {
            List <Transporte> transportes = new List<Transporte>();
            int j = 0;
            int length = 5;
            string tipoVehiculo = "Avion";

            for (int i = 0; i < length; i++)
            {
                transportes.Add(new Avion(i + 1));
            }

            for (int i = 0; i < length; i++)
            {
                transportes.Add(new Automovil(i + 1));
            }

            foreach (var item in transportes)
            {
                if (j > length - 1)
                {
                    tipoVehiculo = "Auto";
                    j = 0;
                }
                Console.WriteLine($" {tipoVehiculo} {j} : {item.GetPasajero()} pasajeros!");

                j++;
            }
        }
    }
}
