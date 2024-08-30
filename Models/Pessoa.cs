using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntroduceAmbiensNet.Models
{
    public class Pessoa
    {
        public string Nome { get; set; }="Thais";
        public int Idade { get; set; }=25;

        public void Apresentar()
        {
            Console.WriteLine($"Olá meu nome é {Nome}, e tenho a {Idade} anos");
        }

    }

}