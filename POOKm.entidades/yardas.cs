using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOKm.entidades
{
    public class yardas
    {
        private float _distancia;

        public float Distancia
        {
            get { return _distancia; }
        }

        public yardas(float distancia)
        {
            if (distancia >= 0)
                _distancia = distancia;
            else
                throw new ArgumentException("La distancia debe ser mayor o igual a cero.");
        }

        public yardas() : this(0)
        {
        }

        public static implicit operator float(yardas yardas)
        {
            return yardas.Distancia;
        }

        public static implicit operator yardas(float distancia)
        {
            return new yardas(distancia);
        }

        public static yardas operator +(yardas yardas, Kilometros km)
        {
            float distanciaEnYardas = yardas.Distancia + (km.Distancia * 1093.61f);
            return new yardas(distanciaEnYardas);
        }
        //1093.61 es lo que equivale 1 km en yardas
        public static yardas operator -(yardas yardas, Kilometros km)
        {
            float distanciaEnYardas = yardas.Distancia - (km.Distancia * 1093.61f);
            return new yardas(distanciaEnYardas);
        }

        public static bool operator ==(yardas yardas1, yardas yardas2)
        {
            return yardas1.Distancia == yardas2.Distancia;
        }

        public static bool operator !=(yardas yardas1, yardas yardas2)
        {
            return yardas1.Distancia != yardas2.Distancia;
        }

        public override bool Equals(object obj)
        {
            if (obj is yardas)
                return this == (yardas)obj;
            else
                return false;
        }

        public override int GetHashCode()
        {
            return _distancia.GetHashCode();
        }
    }
}
