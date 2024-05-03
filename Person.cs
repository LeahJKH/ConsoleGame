using System.Dynamic;

public class Person {

    public string? Name {get; set;}
    public int? Age {get; set;}
    public Person (string? name, int? age){
        Name = name;
        Age = age;
    }
    public void Getperson(string Name, int Age) {
        if (Age >= 18 ) {
        Console.WriteLine($"welcome, {Name}! you are {Age}!");
        }
        else {
            Console.WriteLine($"{Name}! you are {Age}! Get off the site!!!");
        }
    }
    
}