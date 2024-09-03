public class Person
    {
        public string? Name { get; set; }
        public int? Age { get; set; }
        public Person(string? name, int? age)
        {
            Name = name;
            Age = age;
        }
        public void Getperson(string Name, int Age)
        {
            if (Age >= 18)
            {
                Console.WriteLine($"Welcome, {Name}! You are {Age}!");
                SceneTwo(Name, Age);
            }
            else
            {
                Console.WriteLine($"{Name}! You are {Age}! Get off the site!!!");
            }
        }
        public void SceneTwo(string Name, int Age)
        {
            Console.WriteLine("So you wake up in a damp cellar");
            Console.WriteLine($"{Name}- this is why I don't drink often");
            Console.WriteLine("You see a door and a bed. Something is beside you. What do you do?");
            string action = Console.ReadLine(); 
            if (action.ToLower().Contains("bed")) 
            {
                Console.WriteLine("You check the bed.");
            }
        }
    }
