//Exercício - 1; 
//Mostrar para o usuário o dia em que ele estiver vivo 
//Criação de validação de data de nascimento
/*
    -> criação de um tratamento de exceção para tratar System.FormatException;
    -> fazer com que o programa execute novamente caso ocorra o erro;
    -> criação de classe pessoa para tratamento de erros; 
    -> perguntar para o usuário infinitamente a data e o nome até o momento em que ele responda corretamente; 
        -> um while(true) já resolveria esse problema de código;
        -> utilização de String.IsNullOrEmpty, para tratar erro de pergunta do nome;   
    -> criar funções para as entradas de informações do usuário; 
    -> fazer as validações nessas funções; 
*/

using System.Runtime.InteropServices.ComTypes;

Console.WriteLine(PegarNome());

Console.Write("Pressione qualquer tecla para fechar a aplicação...");
Console.ReadKey();
//
// DateTime dataDaMorte = PegaDataDeNascimento().AddYears(100);
// Console.WriteLine($"Alô, {nome}. Você viverá até {dataDaMorte.ToShortDateString()}");
// Console.WriteLine("Pressione qualquer tecla para fechar o programa");
// Console.ReadKey();
//
// Console.WriteLine("Não é um formato de dado válido");

string PegarNome()
{
    Console.Write("Digite o seu nome: ");
    string nome = Console.ReadLine();
    
    if (String.IsNullOrEmpty(nome))
    {
        return "Esse não é um nome válido. Tente digitar novamente...";
    }
    return nome;        
}

//
// string PegaNome()
// {
//     Console.Write("Por favor, insira o seu nome: ");
//     string nome = Console.ReadLine();
//     if (String.IsNullOrEmpty(nome))
//     {
//         Console.WriteLine("Esse não é um nome válido!");
//     }
//     else return nome;
// }

DateTime PegaDataDeNascimento()
{
    Console.Write("Insira a sua data de nascimento: ");
    return DateTime.Parse(Console.ReadLine()!);
}

