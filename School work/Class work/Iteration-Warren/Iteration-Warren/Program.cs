//Exercise 1
static void CountDown(int n)
{

    for (int a = n; a >= 0; --a)
    {
        Console.WriteLine(a);
    }
    Console.WriteLine("Blast-Off");
}

//Exercise 2
static void drawStar(int n)
{
    for (int i = 1; i <= n; i++)
    {
        Console.WriteLine(new string('*', i));
    }
}

//Exercise 3 
static void drawGrid(int numRow, int numColumn)
{
    string row = "+---";
    string column = "|   ";
    for (int r = 0; r < numRow; r++)
    {
        Console.WriteLine(string.Concat(Enumerable.Repeat(row, numColumn)) + "+");
        Console.WriteLine(string.Concat(Enumerable.Repeat(column, numColumn)) + "|");

    }
    Console.WriteLine(string.Concat(Enumerable.Repeat(row, numColumn)) + "+");

}
drawGrid(4, 3);

//Exercise 5
static void menu()
{
    while (true)
    {
        Console.Write("Enter question number: ");
        string input = Console.ReadLine();

        if (input == "1")
        {
            CountDown(5);
            break;
        }
        else if (input == "2")
        {
            drawStar(5);
            break;
        }
        else
        {
            Console.WriteLine("Haven't done this exercise yet.");
        }

    }
}

//Exercise 6
static void Ask(int n)
{
    decimal sum = 0;

    for (int i = 0; i < n; i++)
    {
        decimal num;

        while (true)
        {
            Console.Write("Enter number: ");
            string input = Console.ReadLine();
            if (decimal.TryParse(input, out num))
                break;
            else
                Console.WriteLine("Invalid input");  
        }

        sum += num;
    }

    decimal mean = sum / n;
    Console.WriteLine($"The mean is {mean}");
}

//Exercise 7a
static bool isPrime(int n)
{
    if (n <= 1) return false;
    else if (n == 2) return true;


    for (int i = 2; i < n; i++)
    {
        if (n % i == 0)
            return false;
    }
    return true;

}
Console.WriteLine(isPrime(17));

//Exercise 7b
static bool isPerfect(int n)
{
    int sumDivisors = 0;

    for (int i = 1; i < n; i++)
    {
        if (n % i == 0)
        {
            sumDivisors += i;
        }
    }

    return sumDivisors == n;
}
Console.WriteLine(isPerfect(90));

//Exercise 7c
static bool isAbundant(int n)
{
    int sumDivisors = 0;

    for (int i = 1; i < n; i++)
    {
        if (n % i == 0)
        {
            sumDivisors += i;
        }
    }

    return sumDivisors > n;
}
Console.WriteLine(isAbundant(90));

//Exercise 7d
static bool isFriendly(int n, int p)
{
    int sumDivisorsOfn = 0;
    int sumDivisorsOfp = 0;
    double abundancyIndexOfn = 0;
    double abundancyIndexOfp = 0;

    for (int i = 1; i < n; i++)
    {
        if (n % i == 0) sumDivisorsOfn += i;
    }

    for (int i = 1; i < p; i++)
    {
        if (p % i == 0) sumDivisorsOfp += i;
    }

    abundancyIndexOfn = (double)sumDivisorsOfn / n;
    abundancyIndexOfp = (double)sumDivisorsOfp / p;

    return abundancyIndexOfn == abundancyIndexOfp;
}

//Exercise 9
static void guessNum(int low, int high)
{

    while (low <= high)
    {
        int guess = (high - low) / 2;

        Console.WriteLine($"My guess is {guess}. Is it high, low, or correct?");
        string response = Console.ReadLine().ToLower();

        if (response == "correct")
        {
            Console.WriteLine("I have guessed right.");
            return;
        }
        else if (response == "high") high = guess - 1;
        else if (response == "low") low = guess + 1;
        else Console.WriteLine("Invalid input.");

    }
}

// Exercise 11
static string reverseWords(string sentence)
{
    string[] words = sentence.Split(' ', StringSplitOptions.RemoveEmptyEntries);
    Array.Reverse(words);
    return string.Join(" ", words);
}

// Exercise 12
for (long n = 1; ; n++)
{
    long lastDigit = n % 10;
    if (lastDigit == 0) continue;

    long restOfDigits = n / 10;
    int numberOfDigits = n.ToString().Length;

    long output = lastDigit * (long)Math.Pow(10, numberOfDigits - 1) + restOfDigits;

    if (output == 2 * n)
    {
        Console.WriteLine($"The number is {n}.");
        break;
    }
}
