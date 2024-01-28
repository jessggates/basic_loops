// question 5 (expanded on 3 & 4 - implement 5 attempt door code with do while loop)

bool locked = true;
string doorCode = "";
int attempt = 0;

do
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
} while (locked == true && attempt < 5) ;

Console.ReadKey();
