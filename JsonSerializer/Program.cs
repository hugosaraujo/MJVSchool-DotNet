using JsonSerializer.Models;

/* Melhorias possíveis
    -> Adicionar linha para criar um arquivo externo com o resultado de ambos os consoles. 
    -> Fazer a dessearilização do objeto; 
    -> Criar um "record" e fazer os mesmos passos que forem feitos na classe; 
*/

Car c = new("Fiat", "157", 1977);
string jsonCarro = System.Text.Json.JsonSerializer.Serialize(c);
Console.WriteLine(jsonCarro);

Person p = new("Alice", 3);
string jsonPessoa = System.Text.Json.JsonSerializer.Serialize(p);
Console.WriteLine(jsonPessoa);

Console.WriteLine("Pressione qualquer tecla para fechar a aplicação");
Console.ReadKey();