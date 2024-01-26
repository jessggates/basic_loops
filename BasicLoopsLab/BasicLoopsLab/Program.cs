
string userInput = "";

do
{
    Console.WriteLine("Hello, World!");
    Console.WriteLine("Would you like to continue (y/n)");
    userInput = Console.ReadLine();
}
while (userInput == "y");
Console.WriteLine("Goodbye!");

