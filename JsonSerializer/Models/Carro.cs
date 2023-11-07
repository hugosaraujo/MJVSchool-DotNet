namespace JsonSerializer.Models;

public class Carro
{
    public Carro(string fabricante, string modelo, int ano)
    {
        Fabricante = fabricante;
        Modelo = modelo;
        Ano = ano; 
    }
    public string Modelo { get; }
    public string Fabricante { get; }
    public int Ano { get; }
}