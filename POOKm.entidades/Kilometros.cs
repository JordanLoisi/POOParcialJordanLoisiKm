using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOKm.entidades
{
    public class Kilometros
    {
        private float _distancia;

        public float Distancia
        {
            get { return _distancia; }
        }

        public Kilometros(float distancia)
        {
            if (distancia >= 0)
                _distancia = distancia;
            else
                Console.WriteLine("La distancia debe ser mayor o igual a cero.");
        }

        public Kilometros() : this(100)
        {
        }

        public static implicit operator float (Kilometros km)
        {
            return km.Distancia;
        }

        public static implicit operator Kilometros(float distancia)
        {
            return new Kilometros(distancia);
        }

        public static Kilometros operator +(Kilometros km, Millas millas)
        {
            float distanciaEnKm = km.Distancia + millas;
            return new Kilometros(distanciaEnKm);
        }

        public static Kilometros operator +(Kilometros km, yardas yardas)
        {
            float distanciaEnKm = km.Distancia + yardas;
            return new Kilometros(distanciaEnKm);
        }

        public static Kilometros operator -(Kilometros km, Millas millas)
        {
            float distanciaEnKm = km.Distancia - millas;
            return new Kilometros(distanciaEnKm);
        }

        public static Kilometros operator -(Kilometros km, yardas yardas)
        {
            float distanciaEnKm = km.Distancia - yardas;
            return new Kilometros(distanciaEnKm);
        }

        public static bool operator ==(Kilometros km1, Kilometros km2)
        {
            return km1.Distancia == km2.Distancia;
        }

        public static bool operator !=(Kilometros km1, Kilometros km2)
        {
            return km1.Distancia != km2.Distancia;
        }

        public override bool Equals(object obj)
        {
            if (obj is Kilometros)
                return this == (Kilometros)obj;
            else
                return false;
        }

        public override int GetHashCode()
        {
            return _distancia.GetHashCode();
        }
    }
}
