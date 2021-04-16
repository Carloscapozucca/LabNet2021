using System;
using System.Collections.Generic;
using System.Text;

namespace Transporte
{
    public class Automovil : Transporte
    {
        private int pasajero;
        public Automovil(int pasajero)
        {
            SetPasajero(pasajero);
        }

        public void SetPasajero(int pasajero)
        {
            this.pasajero = pasajero;
        }

        public int GetPasajero()
        {
            return this.pasajero;
        }

        public void Avanzar()
        {
            Console.WriteLine("Avanzo");
        }

        public void Detenerse()
        {
            Console.WriteLine("Me detengo"); 
        }
    }
}
