namespace JsonSerializer.Models;

public class Person
{
    public Person(string name, int age)
    {
        Name = name;
        Age = age; 
    }
    public string Name { get; }
    public int Age { get; }
}