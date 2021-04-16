using System;
using System.Collections.Generic;
using System.Text;

namespace Transporte
{
    public class Avion : Transporte
    {
        private int pasajero;
        public Avion(int pasajero)
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
            Console.WriteLine("Estoy despegando");
        }

        public void Detenerse()
        {
            Console.WriteLine("Estoy aterrizando");
        }
    }
}
