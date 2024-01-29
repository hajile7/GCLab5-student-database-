//begin our infinite program loop
using System.Security.Cryptography;

bool programRun = true;
while (programRun)
{
    //arrays of information
    string[] Names = { "Rod Mastria", "Elijah Reid", "Logan Reeves", "Dominic Nutaitis", "Ethan Thomas", "Justin Jones" };
    string[] Foods = { "Anything Italian", "Spaghetti", "Wings", "Sushi", "Jambalaya", "Baja Blast" };
    string[] Homes = { "Detroit/SaoPaulo", "Whitehall", "Mansfield", "New Baltimore", "Rolla", "Grand rapids" };

    //welcome + offering to view a list of all students
    Console.WriteLine("Welcome to the student database! Would you like to view a list of all students? y/n");

    //get user input for viewing list
    string listChoice = Console.ReadLine().ToLower().Trim();
    if (listChoice == "y")
    {
        for (int i = 0; i < Names.Length; i++)
        {
            Console.WriteLine(Names[i]);
        }
    }

    Console.Write("Which student would you like to learn more about? If you'd like to search by name instead, please enter 10 now.\nOtherwise, enter a number 1-6: ");

    //get user input
    int choice = (int.Parse(Console.ReadLine()));

    //if user would like to search via name instead
    if (choice == 10)
    {
        //get user input
        Console.Write("Which student would you like to search for? ");
        string nameChoice = Console.ReadLine().ToLower().Trim();
        //if logic based on user's input to set our choice variable to the correct index
        if (nameChoice == "rod mastria") {
            choice = 1;
        }
        else if (nameChoice == "elijah reid")
        {
            choice = 2;
        }
        else if (nameChoice == "logan reeves")
        {
            choice = 3;
        }
        else if (nameChoice == "dominic nutaitis")
        {
            choice = 4;
        }
        else if (nameChoice == "ethan thomas")
        {
            choice = 5;
        }
        else if (nameChoice == "justin jones")
        {
            choice = 6;
        }
    }

    //validate user input
    while (choice < 1 || choice > Names.Length && choice != 10)
    {
        Console.WriteLine("The number you've entered is not within the specified range. Please try again: ");
        choice = (int.Parse(Console.ReadLine()));
    }

    //for loop to search for and output student name
    for (int i = 0;  i < Names.Length; i++)
    {
        if (i == choice - 1)
        {
            Console.Write($"Student {choice} is {Names[i]}.");
        }
    }

    //see if user would like to know more about specified student & store their answer 
    Console.Write(" What would you like to know? Enter \"hometown\" or \"favorite food\": ");
    string extraChoice = Console.ReadLine().ToLower().Trim();

    //valid this second input
    while (extraChoice != "hometown" && extraChoice != "favorite food" && extraChoice != "favorite" && extraChoice != "food" && extraChoice != "home" && extraChoice != "town")
    {
        Console.WriteLine("The option you've enterd is invalid. Please try again: ");
        extraChoice = Console.ReadLine().ToLower().Trim();
    }

    //for loop to output hometown
    if (extraChoice == "hometown" || extraChoice.Contains("home") || extraChoice.Contains("town"))
    {
        for (int i = 0; i < Homes.Length; i++)
        {
            if (i == choice - 1)
            {
                Console.WriteLine($"{Names[i]} is from {Homes[i]}");
            }
        }
    }
    //rest of loop to output favorite food
    else if (extraChoice == "favorite food" || extraChoice.Contains("favorite") || extraChoice.Contains("food"))
    {
        for (int i = 0; i < Foods.Length; i++)
        {
            if (i == choice - 1)
            {
                Console.WriteLine($"{Names[i]}'s favorite food is {Foods[i]}");
            }
        }
    }
    //see if user would like to continue using the program
    while (true)
    {
        Console.WriteLine("Would you like to continue using the student database program? y/n");
        string progChoice = Console.ReadLine().ToLower().Trim();
        if (progChoice == "y")
        {
            break;
        }
        else if (progChoice == "n")
        {
            programRun = false;
            Console.WriteLine("Thank you for using the student database. Goodbye!");
            break;
        }
        else
        {
            Console.WriteLine("Invalid");
        }
    }
}