//Exercise 1
using System.Diagnostics;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

int addInteger(int a, int b)
{
    int sum = a + b;
    return sum;
}
int resultInteger = addInteger(1, 2);

double addDouble(double a, double b)
{
    double sum = a + b;
    return sum;
}
double resultDouble = addDouble(1.0, 2.0);

decimal addDecimal(decimal a, decimal b)
{
    decimal sum = a + b;
    return sum;
}
decimal result = addDecimal(1.0m, 2.0m);

//Exercise 2
int digitSum(int a)
{
    int sum = 0;

    if (a < 0)
    {
        a = -a;
    }

    while (a > 0)
    {
        int digit = a % 10;
        sum += digit;
        a /= 10;
    }

    return sum;
}

//Exercise 3
bool primeTest(int a)
{
    if (a <= 1)
        return false;

    for (int x = 2; x < a; x++)
    {
        if (a % x == 0)
        {
            return false;
        }
    }

    return true;
}

//Exercise 4
int countSpaces(string userString)
{
    int spaceCount = 0;

    foreach (char a in userString)
    {
        if (a == ' ')
        {
            spaceCount++;
        }
    }
    return spaceCount;
}

//Exercise 5
void swap(ref int a, ref int b)
{
    int i = a;
    a = b;
    b = i;
}

//Exercise 6
string convertHex(int num, int numBase)
{
    int remainder;
    string output = " ";
    string hexValue;
    int c = 65;


    while (num != 0)
    {
        num = Math.DivRem(num, numBase, out remainder);
        if (remainder < 0)
        {
            hexValue = remainder.ToString();
        }
        else
        {
            hexValue = ((char)(c + remainder - 10)).ToString();

        }
        output = hexValue + output;
    }
    return output; 
}
Console.WriteLine(convertHex(383, 16));
//Exercise 7
