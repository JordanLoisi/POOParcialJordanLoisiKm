using POOKm.entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOParcialJordanLoisiKm
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Kilometros km1 = new Kilometros(2);
           

            Millas millas1 = new Millas(6.21371f);
          

            yardas yardas1 = new yardas(10936.1f);
           

            Console.WriteLine("Distancia en Kilómetros: {0}", km1.Distancia);
            Console.WriteLine("Distancia en Millas: {0}", millas1.Distancia);
            Console.WriteLine("Distancia en Yardas: {0}", yardas1.Distancia);

            Kilometros km3 = km1 + millas1;
            Console.WriteLine("Suma de Kilómetros y Millas: {0}", km3.Distancia);

            Kilometros km4=km1 - millas1;
            Console.WriteLine("la resta de kilometos y millas:{0}", km4.Distancia);


            Kilometros km5 = km1 + yardas1;
            Console.WriteLine("suma de kilometros y yardas:{0}", km5.Distancia);

            Kilometros km6 = km1 - yardas1;
            Console.WriteLine("resta de kilometros y yardas:{0}", km6.Distancia);



            Console.ReadLine();


        }
    }
}
