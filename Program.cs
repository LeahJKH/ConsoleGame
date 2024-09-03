namespace personConstruct
{
    class Program
    {
        static void Main(string[] args)
        {
            Person newPerson = new Person(null, null);
            Console.WriteLine("please enter name");
            string namerequest = Console.ReadLine()!;
            string name = namerequest;
            Console.WriteLine("please enter age");
            int agerequest = Convert.ToInt32(Console.ReadLine());
            int age = agerequest;
            newPerson.Name = name;
            newPerson.Age = age;

            newPerson.Getperson(name, age);
            Console.WriteLine($"lets get started, {name}");
            Console.WriteLine($"you were {age} years old.... okay, what's your gender actually?");
            string gender = Console.ReadLine();
            Console.WriteLine($"Great, now that I know you are {gender}, we can continue");
            Console.WriteLine("");
            Console.WriteLine("first of all, choose a class");
            Console.WriteLine("1: mage");
            Console.WriteLine("2: barbarian");
            Console.WriteLine("3: swordsman");
            Console.WriteLine("WRITE NUMBER OF THE CLASS YOU WANT:");

            int yourClass = Convert.ToInt32(Console.ReadLine());
            if (yourClass >= 1 && yourClass <= 3) // Corrected condition
            {
                if (yourClass == 1)
                {
                    Console.WriteLine("you chose mage");
                }
                else if (yourClass == 2)
                {
                    Console.WriteLine("you chose barbarian");
                }
                else if (yourClass == 3)
                {
                    Console.WriteLine("you chose swordsman");
                }
            }
            else
            {
                Console.WriteLine("don't be an idiot");
            }
        }
    }}