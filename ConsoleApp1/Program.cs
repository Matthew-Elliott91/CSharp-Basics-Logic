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


// Random Number
//Console.WriteLine("Guess a number");
//int num1;
//Random random = new Random();
//int randomNumber = random.Next(1, 11);
//Console.WriteLine(randomNumber);
//string inputString = Console.ReadLine();

//bool isNumber = int.TryParse(inputString, out num1);

//if (isNumber)
//{
//    if (num1 == randomNumber)
//    {
//        Console.WriteLine("Congratulations you guessed correctly");
//    }
//    else
//    {
//        Console.WriteLine("Unlucky, You didnt get it this time!");
//    }
//}
// Using Try Parse


//Console.WriteLine("Give me a number");
//string inputString = Console.ReadLine();
//int num1;

//bool isNumber = int.TryParse(inputString, out num1);

//num1++;
//Console.WriteLine("User entered number +1 is " + num1);

int int1 = 0;
int int2 = 0;
string operation;
float result = 0;

// First input number
Console.WriteLine("Please enter a number");
string inputString1 = Console.ReadLine();
bool isNumber1 = int.TryParse(inputString1, out int1);

// Second input number
Console.WriteLine("Please enter another number");
string inputString2 = Console.ReadLine();
bool isNumber2 = int.TryParse(inputString2, out int2);

// Choose operation
Console.WriteLine("Do you want to do an Additon, Subtraction, Multiplication or a Division");
operation = Console.ReadLine().Trim().ToLower();

if (operation == "addition")
{
    result = int1 + int2;
    
} else if (operation == "subtraction")
{
    result = int1 - int2;
} else if (operation == "multiplication")
{
    result = int1 * int2;
} else if (operation == "division")
{ if (int1 != 0 && int2 != 0)
    { result = int1 / int2; }
    else { Console.WriteLine("You cant divide by 0"); }
}

Console.WriteLine($"Result: {result}");

Console.ReadKey();