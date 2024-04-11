//int firstValue = 500;
//int secondValue = 600;
//int largerValue = Math.Max(firstValue, secondValue);
//Console.WriteLine(largerValue);
//Random dice = new Random();
//int roll1 = dice.Next(1, 7);
//int roll2 = dice.Next(1, 7);
//int roll3 = dice.Next(1, 7);
//int total = roll1 + roll2 + roll3;
//if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
//{
//    Console.WriteLine("You rolled doubles! +2 bonus to total!");
//    total += 2;
//}
//Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");
//if (total >= 10)
//{
//    Console.WriteLine("You win!");
//}
//else
//{
//    Console.WriteLine("Sorry, you lose.");
//}
//string val1 = "Hello";
//Console.WriteLine(val1);
//string[] arr1 = ["hey", "i", "like", "you"];
//Console.WriteLine(arr1[1]);
//string str = "The quick brown fox jumps over the lazy dog.";
// convert the message into a char array
//char[] charMessage = str.ToCharArray();
// Reverse the chars
//Array.Reverse(charMessage);
//int x = 0;
// count the o's
//foreach (char i in charMessage) {
//     if (i == 'o') { 
//        x++; 
//        } 
//     }
// convert it back to a string
//string new_message = new String(charMessage);
// print it out
//Console.WriteLine(new_message);
//Console.WriteLine($"'o' appears {x} times.");
using System;

// initialize variables - graded assignments 
int currentAssignments = 5;
string gradeFin = "";

int sophia1 = 90;
int sophia2 = 86;
int sophia3 = 87;
int sophia4 = 98;
int sophia5 = 100;

int andrew1 = 92;
int andrew2 = 89;
int andrew3 = 81;
int andrew4 = 96;
int andrew5 = 90;

int emma1 = 90;
int emma2 = 85;
int emma3 = 87;
int emma4 = 98;
int emma5 = 68;

int logan1 = 90;
int logan2 = 95;
int logan3 = 87;
int logan4 = 88;
int logan5 = 96;

int sophiaSum = 0;
int andrewSum = 0;
int emmaSum = 0;
int loganSum = 0;

decimal sophiaScore;
decimal andrewScore;
decimal emmaScore;
decimal loganScore;

sophiaSum = sophia1 + sophia2 + sophia3 + sophia4 + sophia5;
andrewSum = andrew1 + andrew2 + andrew3 + andrew4 + andrew5;
emmaSum = emma1 + emma2 + emma3 + emma4 + emma5;
loganSum = logan1 + logan2 + logan3 + logan4 + logan5;

sophiaScore = (decimal)sophiaSum / currentAssignments;
andrewScore = (decimal)andrewSum / currentAssignments;
emmaScore = (decimal)emmaSum / currentAssignments;
loganScore = (decimal)loganSum / currentAssignments;


int score = 0;

if (score = score >  97 || score < 100) {
gradeFin = "A+";
} 
if (score == 93 - 96 ) {
gradeFin = "A";
} 
if (score == 93 - 96) {
gradeFin =  "A-";
} 
if (score == 87 - 89 ) {
gradeFin = "B+";
} 
if (score == 83 - 86) {
gradeFin = "B";
} 
if (score == 80 - 82 ) {
gradeFin = "B-";
} 

if (score == 77 - 79 ) {
gradeFin = "C+";
} 
if (score == 73 - 76 ) {
gradeFin = "C";
} 
if (score == 70 - 72 ) {
gradeFin = "C-";
} 
if (score == 67 - 69  ) {
gradeFin = "D+";
} 
if (score == 63 - 66  ) {
gradeFin = "D";
} 
if (score == 60 - 62 ) {
gradeFin = "D-";
} 
if (score == 0  - 59 ) {
gradeFin = "F";
} 


Console.WriteLine("Student\t\tGrade\n");
Console.WriteLine("Sophia:\t\t" + sophiaScore + "\t" + gradeFin);
Console.WriteLine("Andrew:\t\t" + andrewScore + "\t" + gradeFin);
Console.WriteLine("Emma:\t\t" + emmaScore + "\t" + gradeFin);
Console.WriteLine("Logan:\t\t" + loganScore + "\t" + gradeFin);

Console.WriteLine("Press the Enter key to continue");
Console.ReadLine();