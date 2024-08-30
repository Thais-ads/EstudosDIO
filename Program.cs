using IntroducaoAmbienteNet.Models;
using IntroduceAmbiensNet.Models;

Pessoa pessoaDados = new Pessoa();
pessoaDados.Nome ="Pedro";
pessoaDados.Apresentar();


////////////////////////////////////////

VariaveisTipos variaveisTipos = new VariaveisTipos ();

variaveisTipos.Testes();


////////////////////////////////////////



Operadores operadores = new Operadores();

operadores.OperadoresCalculos();

operadores.Convertendo();

operadores.CastImplicito();

operadores.OrdemOperadores();

operadores.ConversaoSegura();

////////////////////////////////////////

OperadorCondicional operadorCondicional = new OperadorCondicional();

operadorCondicional.LogicaldeIfes();


////////////////////////////////////////

Calculadora calculadora = new Calculadora();

calculadora.Potencia(3, 3);

calculadora.Seno(30);

calculadora.Coseno(30);

calculadora.Tangente(30);

calculadora.RaizQuadrada(9);


EstruturaRepeticao estrutura = new EstruturaRepeticao();

//estrutura.EstruturaFor();
//estrutura.EstruturaEnquanto();
estrutura.EstruturaDoEnquanto();

Console.Clear();
string opcao;
bool exibirMenu = true;

while (exibirMenu){

Console.WriteLine("Escolha uma opção:");
Console.WriteLine("1 - Cadastrar cliente:");
Console.WriteLine("2 - Buscar cliente:");
Console.WriteLine("3 - Apagar cliente:");
Console.WriteLine("4 - Encerrar:");

opcao = Console.ReadLine();


switch(opcao)
{
    case "1":
        Console.WriteLine("Cadastrar cliente");
        break;
    case "2":
        Console.WriteLine("Buscar cliente");
        break;
    case "3":
        Console.WriteLine("Apagar cliente");
        break;
    case "4":
        Console.WriteLine("Encerrar");
        exibirMenu = false;
       break;
    default:
        Console.WriteLine("Opção inválida!");
        break;
}

}

Console.WriteLine("Salve");