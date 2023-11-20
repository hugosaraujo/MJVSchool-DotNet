//Projeto sorteador de numero de loterias
/* Desenvoler projeto para sortear numero da megasena
    -> Impedir que seja sorteado o mesmo número em um mesmo jogo; 
    -> Dispor o número dos jogos de maneira ordenadas e crescente;
    -> Refatoração de código, separação do código com funções; 
    -> criação de jogador usuário com Nome e ValorPago em suas propriedade;   
    -> mostrar para o usuário, o valor de um possível troco; 
*/

Console.Write("Informe o seu nome: ");
string nome = Console.ReadLine();

Console.WriteLine($"{nome}, informe o valor em reais que quer gastar: ");
double valorPagoCliente = double.Parse(Console.ReadLine());

int valorJogo = 5;
int quantidadeJogos = (int)valorPagoCliente / valorJogo;

for (int i = 0; i < quantidadeJogos; i++)
{
    Random rdm = new Random();
    int[] volante = new int[6];

    for (int j = 0; j < volante.Length; j++)
    {
        int numeroAleatorio = rdm.Next(1, 61);
        volante[j] = numeroAleatorio;
    
        Console.Write($"- {volante[j]} ");
    }
    Console.WriteLine();
}

Console.WriteLine();
Console.Write("Aperte qualquer tecla para fechar a aplicação: ");
Console.ReadKey();