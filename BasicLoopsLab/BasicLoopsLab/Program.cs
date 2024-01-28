
// question 1 (hello world loop and continue if y)

using System.ComponentModel.Design;
using System.Diagnostics.Metrics;
using System.Xml.Linq;

string userInput = "";

do
{
    Console.WriteLine("Hello, World!");
    Console.WriteLine("Would you like to continue (y/n)");
    userInput = Console.ReadLine().ToLower().Trim();
}
while (userInput == "y");
Console.WriteLine("Goodbye!");
Console.WriteLine();

//  question 2 (user picks number, count down then count up, and continue if y)

int userNumber = 0;
string keepPlaying = "";

do
{
    Console.Write("Enter a number: ");
    userNumber = int.Parse(Console.ReadLine());

    for (int i = userNumber; i >= 0; i--)
    {
        Console.Write(i + " ");
    }
    {
        Console.WriteLine();
    }
    for (int i = 0; i <= userNumber; i ++)
    {
        Console.Write(i + " ");
    }
    {
        Console.WriteLine();
    }

    Console.WriteLine("Would you like to continue? (y/n)");
    keepPlaying = Console.ReadLine().ToLower().Trim();
}
while (keepPlaying == "y");
Console.WriteLine("Goodbye!");
Console.WriteLine();


// question 3  (while loop for door code until it is correct)

bool locked = true;
string doorCode = "";

while (locked == true) 
{
    Console.WriteLine("Enter the door code");
    doorCode = Console.ReadLine();

    if (doorCode == "13579")
    {
        Console.WriteLine("Welcome, come on in!");
        locked = false;
    }
    if (doorCode != "13579")
    {
        Console.WriteLine("Wrong code, try again!");
        Console.WriteLine();
    }
}

Console.ReadKey();

// question 4 (expanded on 3 - loop for door code, stop after 5 incorrect attempts)

int attempt = 0;

while (locked == true)
{
    Console.WriteLine("Enter the door code");
    doorCode = Console.ReadLine();

    if (doorCode == "13579")
    {
        Console.WriteLine("Welcome, come on in!");
        locked = false;
        break;
    }
    else if (++attempt < 5)
    {
        Console.WriteLine("Wrong door code, try again!");
        Console.WriteLine();
    }
    else
    {
        Console.WriteLine("Sorry, too many wrong attempts!");
        break;
    }
} 

Console.ReadKey();