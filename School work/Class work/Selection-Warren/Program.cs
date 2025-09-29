//exercise 1
using System.Globalization;

void testForEqualNumbers()
{
    Console.Write("Enter an integer: ");
    string userNum1 = Console.ReadLine();
    Console.Write("Enter another integer: ");
    string userNum2 = Console.ReadLine();

    if (userNum1 == userNum2)
    {
        Console.WriteLine("They are equal.");
    }
    else
    {
        Console.WriteLine("They are not equal.");
    }
}

//exercise 2
void testForEvenNumbers()
{
    Console.Write("Enter an integer: ");
    string userInput = Console.ReadLine();
    int userNum = int.Parse(userInput);

    if (userNum % 2 == 0)
        Console.WriteLine("It is an even number.");
    else
        Console.WriteLine("It is an odd number");
}

//exercise 3
void testForLeapYears()
{
    Console.Write("Enter a year: ");
    string userInput = Console.ReadLine();
    int year = int.Parse(userInput);

    if (year % 4 == 0)
        Console.WriteLine($"The year {year} is a leap year.");
    else
        Console.WriteLine("It isnt't a leap year.");
}

//exercise 4
void divisibilityTest()
{
    Console.Write("Enter a number: ");
    string userInput = Console.ReadLine();
    int num = int.Parse(userInput);

    if (num % 3 == 0)
        Console.WriteLine("Fizz");
    else if (num % 5 == 0)
        Console.WriteLine("Buzz");
    else if (num % 3 == 0 && num % 5 == 0)
        Console.WriteLine("FizzBuzz");
    else
        Console.WriteLine(userInput);
}

//Exercise 5
void factorTest()
{
    Console.Write("Enter an integer: ");
    int num = Convert.ToInt32(Console.ReadLine());
    int numberOfFactors = 0;
    for (int i = 1; i <= num; i++)
    {
        if (num % i == 0)
        {
            numberOfFactors++;
        }
    }
    Console.WriteLine($"There are {numberOfFactors}.");
}

//Exercise 6
void checkVowel()
{
    Console.Write("Enter a letter: ");
    string letter = Console.ReadLine();
    switch (letter)
    {
        case "a":
            Console.WriteLine("It is a vowel");
            break;
        case "e":
            Console.WriteLine("It is a vowel");
            break;
        case "i":
            Console.WriteLine("It is a vowel");
            break;
        case "o":
            Console.WriteLine("It is a vowel");
            break;
        case "u":
            Console.WriteLine("It is a vowel");
            break;
    }
}

//Exercise 7
void countBlocks()
{
    const int blocksize = 512;
    const int KiBToBytes = 1024;

    Console.Write("Enter a number in KiB: ");
    string userInput = Console.ReadLine();
    int numberInKiB = Convert.ToInt32(userInput);
    int numberInBytes = numberInKiB * KiBToBytes;
    int blocks = numberInBytes / blocksize;

    if (numberInBytes % blocksize != 0)
    {
        blocks++;
    }

    Console.WriteLine($"The file requires {blocks} blocks.");
}
