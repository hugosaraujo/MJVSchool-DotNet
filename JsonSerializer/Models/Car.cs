namespace JsonSerializer.Models;

public class Car
{
    public Car(string automaker, string model, int year)
    {
        Automaker = automaker;
        Model = model;
        Year = year; 
    }
    public string Model { get; }
    public string Automaker { get; }
    public int Year { get; }
}