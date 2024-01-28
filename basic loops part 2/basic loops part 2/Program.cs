bool locked = true;
string doorCode = "";


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