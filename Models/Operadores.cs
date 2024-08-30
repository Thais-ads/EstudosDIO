using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntroducaoAmbienteNet.Models
{
    public class Operadores
    {
        int a = 10;

        int b = 20;



        public void OperadoresCalculos()
        {
        int c = a + b;
        c = c+ 1;
        c -= a;
         Console.WriteLine($"O resultado é {c}");
        }



        public void Convertendo()
        {
            //Cast - casting
            //convertendo strig para numero;
          int a = Convert.ToInt32("6");

          Console.WriteLine($" A conversão somada dá: {a + 7}");   
 
          int b = int.Parse("1");

          Console.WriteLine($" A conversão  dá: {b}");  

        
          string texto = a.ToString();


            Console.WriteLine($" A conversão  dá: {texto + 2}");  


        }

        public void CastImplicito()
        {

                 int a = int.MaxValue;

                 long b = a;

                Console.WriteLine(b);
                
        }


         public void OrdemOperadores()
        {

                 double a = 4 / (2 + 2);

                Console.WriteLine($"A resposta é :{a}");
                
        }

         public void ConversaoSegura()
        {

                string a = "4-";

                int b = 0; 

                
                Console.WriteLine(int.TryParse(a, out b));
                Console.WriteLine("Mensagem com sucesso");
        }

    }


}