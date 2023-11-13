using System.Threading.Channels;

Console.WriteLine("Projeto apenas para testar os trechos de código passados em aula");

Pessoa p = new Pessoa();
p.Nome = "Hugo";
p.Idade = 29;

Pessoa p1 = new Pessoa();
p1.Nome = "Hugo";
p1.Idade = 29;

bool comparacaoNomes = p.Nome == p1.Nome; 

Console.WriteLine(comparacaoNomes);


Console.WriteLine("Pressione qualquer tecla para fechar a aplicação");
Console.ReadKey();


struct Pessoa
{
    public string Nome { get; set; }
    public int Idade { get; set; }
}