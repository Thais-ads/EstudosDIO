using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntroducaoAmbienteNet.Models
{
    public class VariaveisTipos
    {
        
        public void Testes(){
            string texto = "Olá BORÁ";
            int quantidade = 25;
            double altura = 1.70;
            decimal preco = 1.80M;
            bool condicao = true;

            DateTime tipoData = DateTime.Now;



            Console.WriteLine(texto);
            Console.WriteLine(quantidade);
            Console.WriteLine(altura.ToString("0.00"));
            Console.WriteLine(preco);
            Console.WriteLine(condicao);
            Console.WriteLine(tipoData);
            Console.WriteLine(tipoData.ToString("dd/MM/yyyy"));
            Console.WriteLine(tipoData.ToString("HH:mm:ss"));
            //CONVENSOES

            //*PascalCase = nome de Classe e nome de Atributos e Methodos;

            //*camelCase = escrever variavel começando com minusculo exemplo: pessoaFisicaRepresentacao;

        }


    }
}