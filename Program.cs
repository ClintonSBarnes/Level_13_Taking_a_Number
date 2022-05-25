// See https://aka.ms/new-console-template for more information

//establishes variables
string text = "What is the airspeed velocity of an unladen swallow?";
string text2 = "Choose a number between: ";
int userNumber = -1;

//calls the functions
userNumber = AskingForANumber(text);
int userNumberWithinRange = AskForNumberInRange(text2, 5, 14);


//fuction that returns an int from a string input
int AskingForANumber(string text)
{
    Console.WriteLine(text);
    int result;
    result = Convert.ToInt16(Console.ReadLine());
    return result;
}

//function that checks that the user has input an int within the designated range.
int AskForNumberInRange(string text2, int min, int max)
{
    int userRangeGuess = 0;

    while (userRangeGuess > max || userRangeGuess < min)
    {
        Console.WriteLine(text2 + " " + min + " and " + max + ".");
        userRangeGuess = Convert.ToInt16(Console.ReadLine());

        if (userRangeGuess > max || userRangeGuess < min)
        {
            Console.WriteLine("\nYour number is not within the range.");
        }
    }
    return userRangeGuess;
}


Console.ReadKey();