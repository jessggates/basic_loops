
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
    }
}