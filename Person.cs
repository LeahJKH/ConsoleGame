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
            Thread.Sleep(2000);
            Console.WriteLine($"{Name}: this is why I don't drink often");
            Console.WriteLine("You see a door and a bed. Something is beside you. What do you do?");
            string action = Console.ReadLine(); 
            if (action.ToLower().Contains("bed")) 
            {
                if(action.ToLower().Contains("sleep"))
                {
                    Console.WriteLine("You go to sleep");
                    Thread.Sleep(2000);
                    Console.WriteLine("you died");
                
                } 
                Console.WriteLine($"{action}");
            }
            if (action.ToLower().Contains("door")) 
            {
                Console.WriteLine($"{action}");
            }
            if (action.ToLower().Contains("beside")) 
            {
                Console.WriteLine($"{action}");
            }
            if (!action.ToLower().Contains("bed") && !action.ToLower().Contains("door") && !action.ToLower().Contains("beside"))
            {
                Console.WriteLine("you cant do that");
            }
        }
    }
