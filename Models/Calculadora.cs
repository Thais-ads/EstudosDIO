using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntroducaoAmbienteNet.Models
{
    public class Calculadora
    {
        public void Potencia(int x , int y )
        {

           double Pot = Math.Pow(x, y);

            Console.WriteLine($"A Potencia calculada é: {Pot}");

        }


        public void Seno(double angulo)
        {
            double radiano = angulo * Math.PI / 180;

            double seno =  Math.Sin(radiano);

            Console.WriteLine($"calculo seno {seno}");
        }

        public void Coseno(double angulo)
        {
            double radiano = angulo * Math.PI / 180;

            double coseno =  Math.Cos(radiano);

            Console.WriteLine($"calculo coseno {coseno}");
        }


        public void Tangente(double angulo)
        {
            double radiano = angulo * Math.PI / 180;

            double tangente =  Math.Tan(radiano);

            Console.WriteLine($"calculo Tangente {tangente}");
        }


         public void RaizQuadrada(double x)
        {
            double raiz = Math.Sqrt(x) ;

            Console.WriteLine($"A Raiz quadrada é:  {raiz}");
        }

    }
}