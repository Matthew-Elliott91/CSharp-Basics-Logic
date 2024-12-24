// See https://aka.ms/new-console-template for more information

// Bool is a datatype in C#
bool isRainy = false;
bool hasUmbrella = true;

// if statements require two ==
if (!isRainy == false) {
    Console.WriteLine( "I will be protected");
}
// Logical Operatorsq
// &&
// ||
// Not !

// Relational Operators 

int num1 = 0;
int num2 = 0;

bool isEqual = num1 == num2;
/*
Console.WriteLine("Please guess a number");

if (num1 == int.Parse(Console.ReadLine()))
{
    Console.WriteLine("Your guess was correct");
}
else {
    Console.WriteLine("Your guess was incorrect");
}*/

bool isWithParents = false;
Console.WriteLine("Please enter your age");
int age = int.Parse(Console.ReadLine());
Console.WriteLine("Are you with your parents");
string parentsQuestion = Console.ReadLine();    




if (age >= 18 && isWithParents)
{
    Console.WriteLine("You can go to the club");
}
else if (age <= 10)
{
    Console.WriteLine("Go to Primary School");
}
else 
{ 
    Console.WriteLine("Go to Secondary School");
}

Console.ReadKey();