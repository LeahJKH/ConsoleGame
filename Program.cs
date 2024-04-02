//int firstValue = 500;
//int secondValue = 600;
//int largerValue = Math.Max(firstValue, secondValue);
//Console.WriteLine(largerValue);
Random dice = new Random();

int roll1 = dice.Next(1, 7);
int roll2 = dice.Next(1, 7);
int roll3 = dice.Next(1, 7);


int total = roll1 + roll2 + roll3;

if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
{
    Console.WriteLine("You rolled doubles! +2 bonus to total!");
    total += 2;
}
Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

if (total >= 10)
{
    Console.WriteLine("You win!");
}
else
{
    Console.WriteLine("Sorry, you lose.");
}

Console.WriteLine(int);