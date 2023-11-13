//Exercício - 1; 
//Mostrar para o usuário o dia em que ele estiver vivo 
//Criação de validação de data de nascimento;
    //criação de um tratamento de exceção para tratar System.FormatException
//Criação dos outros projetos do curso da MJV
/*
    -> criação de projeto de loteria para sortear jogos
*/

using System.Runtime.InteropServices.ComTypes;

Console.Write("Insira o seu nome: ");
string userName = Console.ReadLine()!;

Console.Write("Insira a sua data de nascimento: ");
DateTime userBirthDate = DateTime.Parse(Console.ReadLine()!);

DateTime userDeath = userBirthDate.AddYears(100);

Console.WriteLine($"Alô, {userName}. Você viverá até {userDeath.ToShortDateString()}");

Console.WriteLine("Pressione qualquer tecla para fechar o programa");
Console.ReadKey();