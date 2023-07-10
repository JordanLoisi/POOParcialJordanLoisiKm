using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOKm.entidades
{
    public  class Millas
    {
        private float _distancia;

        public float Distancia
        {
            get { return _distancia; }
        }

        public Millas(float distancia)
        {
            if (distancia >= 0)
                _distancia = distancia;
            else
                Console.WriteLine("La distancia debe ser mayor o igual a cero.");
        }

        public Millas() : this(0)
        {
        }

        public static implicit operator float(Millas millas)
        {
            return millas.Distancia;
        }

        public static implicit operator Millas(float distancia)
        {
            return new Millas(distancia);
        }

        public static Millas operator +(Millas millas, Kilometros km)
        {
            float distanciaEnMillas = millas.Distancia + (km.Distancia * 0.621371f);
            return new Millas(distanciaEnMillas);
        }

        public static Millas operator -(Millas millas, Kilometros km)
        {
            float distanciaEnMillas = millas.Distancia - (km.Distancia * 0.621371f);
            return new Millas(distanciaEnMillas);
        }

        public static bool operator ==(Millas millas1, Millas millas2)
        {
            return millas1.Distancia == millas2.Distancia;
        }

        public static bool operator !=(Millas millas1, Millas millas2)
        {
            return millas1.Distancia != millas2.Distancia;
        }

        public override bool Equals(object obj)
        {
            if (obj is Millas)
                return this == (Millas)obj;
            else
                return false;
        }

        public override int GetHashCode()
        {
            return _distancia.GetHashCode();
        }
    }
}

