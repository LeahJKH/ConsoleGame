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
        SceneTwo(Name, Age)
        }
        else {
            Console.WriteLine($"{Name}! you are {Age}! Get off the site!!!");
        }
    }
    public void SceneTwo(Name, Age) {
        Console.WriteLine("so you wake up in a damp cellar")
        Console.WriteLine($"{Name}- this is why i dont drink often")
        Console.WriteLine("you see a door and a bed something is beside you")
        action = Console.ReadLine()
        if(action.ToLower.Contains("bed")) 
        {
            
        }
    }
    
}