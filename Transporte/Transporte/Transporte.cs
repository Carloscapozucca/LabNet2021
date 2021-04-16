using System;
using System.Collections.Generic;
using System.Text;

namespace Transporte
{
    public interface Transporte {

        public void Avanzar();
        public void Detenerse();
        public void SetPasajero(int pasajero);
        public int GetPasajero();
    }
}
