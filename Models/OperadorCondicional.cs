using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntroducaoAmbienteNet.Models
{
    public class OperadorCondicional
    {
        

        //ecomerce venda produto , precisa ver se tme quantidade suficiente em estoque
        //caso tenha então realize a venda
        //caso nao, caso o usuario queira maior que o disponivel enviar uma msg ao cliente dizendo que nao tem;
        public void LogicaldeIfes(){

            int quantidade = 20;

            Console.WriteLine("Digite a quantidade desejada do produto: ");
            int quantidadeDesejada = Convert.ToInt32(Console.ReadLine());

            bool quant = quantidadeDesejada > 0 &&  quantidadeDesejada <= quantidade;

            if(quantidadeDesejada == 0) {
             Console.WriteLine($"Você não deseja nada.");
            }
            else if(quant){
                Console.WriteLine($"Temos a quantidade solicitada {quantidade}");
            }
            else
            {
             Console.WriteLine($"Não temos a quantidade solicitada;");
            }

           



        }
    }
}