using System.IO.Pipelines;

Console.Write("Enter an integer: ");
string userInput = Console.ReadLine();

if (int.TryParse(userInput, out int number))
{
    Console.WriteLine($"\nHere is the multiplication table for {number}.");

    for (int i = 0; i <= 12; i++)
    {
        int result = number * i;
        Console.WriteLine($"{number,4} x {i,2} = {result,4}");
    }
}
else
{
    Console.WriteLine("That was not a valid integer.");
}