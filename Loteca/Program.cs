//Projeto sorteador de numero de loterias
/* Desenvoler projeto para sortear numero da megasena
    -> O valor de cada aposta é de 5.00 reais; 
    ->Impedir que seja sorteado o mesmo número em um mesmo jogo; 
    ->Dispor o número dos jogos de maneira crescente; 
    ->Perguntar ao usuário o nome e quanto de dinheiro ele quer gastar em jogos; 
*/

decimal valorJogo = 5.00m;

Random rdm = new Random();
int[] volante = new int[6];

for (int i = 0; i < volante.Length; i++)
{
    int numeroAleatorio = rdm.Next(1, 10);
    volante[i] = numeroAleatorio;
    
    Console.Write($"- {volante[i]} ");
}

Console.WriteLine();
Console.Write("Aperte qualquer tecla para fechar a aplicação: ");
Console.ReadKey();