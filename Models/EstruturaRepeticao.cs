using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml;

namespace IntroducaoAmbienteNet.Models
{
    public class EstruturaRepeticao
    {
        public void EstruturaFor(){

            for(int i = 0; i <= 10; i++)
            {
                Console.WriteLine($"Numero: {i}");
            }
        }

        public void EstruturaEnquanto(){

            int i = 0;
            int numero = 10;

            while (i <= numero){
                Console.WriteLine($"A Tabuada do {i} x {numero} = {i * numero}");
                if(i == 5){

                        break;
                }
                i++;

                
                
            }

            
        }


        public void EstruturaDoEnquanto(){

            int soma = 0, numero = 0;

            do{

                Console.WriteLine("Digite um numero: 0 parar ");
                numero = Convert.ToInt32(Console.ReadLine());            
                soma += numero;

            }while(numero != 0);

            
        }

       
    }
}

