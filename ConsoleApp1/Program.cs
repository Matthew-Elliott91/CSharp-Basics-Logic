// See https://aka.ms/new-console-template for more information

// Bool is a datatype in C#
using System.Net.Sockets;

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

/* int num1 = 0;
int num2 = 0;
int age = 0;
string address;

Console.WriteLine("How old are you");
age = int.Parse(Console.ReadLine());

if (age >= 18)
{
    Console.WriteLine("You can go to the club");
}
else
{
    Console.WriteLine("Are you with your parents");
    string withParents = Console.ReadLine();
    if (withParents == "yes")
    {
        Console.WriteLine("You can go to the club");
    }
    else { Console.WriteLine("You can not go to the club"); }
}
bool isEqual = num1 == num2;
bool isNotEqual = num1 != num2;
*/
// Console.WriteLine("Please enter a whole number");
/*
Console.WriteLine("Please guess a number");

if (num1 == int.Parse(Console.ReadLine()))
{
    Console.WriteLine("Your guess was correct");
}
else {
    Console.WriteLine("Your guess was incorrect");
}*/

//bool isWithParents = false;
//Console.WriteLine("Please enter your age");
//int age = int.Parse(Console.ReadLine());
//Console.WriteLine("Are you with your parents");
//string parentsQuestion = Console.ReadLine();    




/*if (num1 == int.Parse(Console.ReadLine()))
{
    Console.WriteLine("The numbers are equal");

    Console.WriteLine("Please enter your age");
    age = int.Parse(Console.ReadLine());  
    if (age >= 18)
    {
        Console.WriteLine("Enter your address so we can send you a prize");
        address = Console.ReadLine();    
    } else
    {
        Console.WriteLine("You are not old enough to win a prize");
    }
}
else
{
    Console.WriteLine("Numbers are not equal");
}*/

// One line if statements or shorthand
int month = 5;
string monthName;

if (month == 1)
{ monthName = "January";
} else if (month == 2) {
    monthName = "February";
} else if (month == 3)
{
    monthName = "March";
} else if (month == 4)
{
    monthName = "Unknown";
}

    // Switch Statement

    switch (month)
{
    case 1: monthName = "January";
        break;
    case 2: monthName = "February";
        break;
    case 3: monthName = "March";
        break;  

    default:
        monthName = "Unknown";
        break;
}

int day = 3;

switch (day)
{
    case 1: day = 1;
        Console.WriteLine("Monday");
        break;
    case 2: day = 2;
        Console.WriteLine("Tuesday");
        break;
    case 3: day = 3;
        Console.WriteLine("Wednesday");
        break;
    default:
        Console.WriteLine("Anotherday");
        break;
}

Console.ReadKey();