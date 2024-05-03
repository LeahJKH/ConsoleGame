namespace personConstruct;
    class Program 
    {
    static void Main(string[] args) {

        Person newPerson = new Person(null, null);
        Console.WriteLine("please enter name");
        string namerequest = Console.ReadLine();
        string name = namerequest;
        Console.WriteLine("please enter age");
        int agerequest = Convert.ToInt32(Console.ReadLine());
        int age = agerequest;
        newPerson.Name = name;
        newPerson.Age = age;

        

        newPerson.Getperson(name, age);
        Console.WriteLine($"lets get started, {name}");
        Console.WriteLine($"you where a {age} old.... okay whats your gender actually");
        string gender = Console.ReadLine();
        Console.WriteLine($"Great, now that i know you are {gender} we can continue");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("first of all choose a class");
        Console.WriteLine("1: mage");
        Console.WriteLine("2: barbarian");
        Console.WriteLine("3: swordsman");
         Console.WriteLine("WRITE NUMBER OF THE CLASS YOU WANT:");
         
        int yourClass = Convert.ToInt32(Console.ReadLine());
        if (yourClass <= 3 || yourClass >= 1)
        {
                if(yourClass == 1) {
            Console.WriteLine("you choose mage");
            }
            if(yourClass == 2) {
            Console.WriteLine("you choose barbarian");
            }
            if(yourClass == 3) {
            Console.WriteLine("you choose swordsman");
            }
        } else {
            Console.WriteLine("dont be an idiot");
        }
      
        
    }
    }



