using System.Diagnostics;
using System.Globalization;
using System.Text;
using System.Text.Unicode;
//Exercise 1
static void WaveFunction(string userInput)
{
    for (int i = 0; i < userInput.Length; i++)
    {
        if (userInput.Substring(i, 1).Equals(" ")) continue;
        else
        {
            string x = userInput.Substring(i, 1).ToUpper();
            for (int a = 0; a < userInput.Length; a++)
            {
                if (a == i) Console.Write(x);
                else Console.Write(userInput.Substring(a, 1));
            }
            Console.Write(" ");
        }

    }
    Console.WriteLine(" ");
}
WaveFunction("hello");

//Exercise 2
string word = "hello 你好";
foreach (char c in word)
{
    int x = (int)c;
    Console.Write(x + " ");
}

//Exercise 3
static string PrintBytes(string input)
{
    byte[] bytes = Encoding.Default.GetBytes(input);
    string outPut = $"Byte array is [{string.Join(",", bytes)}]";
    return outPut;
}
string expectedResult = "Byte array is [104,105]"; 
Debug.Assert(PrintBytes("hi")== expectedResult);


//Exercise 4
static string ReturnString(Array characterCodes)
{
    StringBuilder sb = new StringBuilder();

    foreach (int code in characterCodes)
    {
        sb.Append(char.ConvertFromUtf32(code));
    }
    return sb.ToString();
}
int[] greek = {206, 188, 206, 174, 206, 187, 206, 191};
Console.WriteLine(ReturnString(greek));

//Exercise 5
static int AnagramNumber(string word, List<string> anagrams)
{
    int output = 0;
    string sortedWord = String.Concat(word.OrderBy(c => c));

    foreach (string anagram in anagrams)
    {
        if (anagram.Length != word.Length) continue;

        string sortedAnagram = String.Concat(anagram.OrderBy(c => c));

        if (sortedAnagram == sortedWord) output ++;
    }
    return output;
}

List<string> testing = new List<string>() {"elloh", "sh", "hello", "hhelo"};
Debug.Assert((AnagramNumber("hello", testing)) == 2);

//Exercise 6
static string VariableNameHelper(string input, string choice)
{
    string output = "";
    choice = choice.ToLower();
    string[] splitedString = input.Split(' ');

    if (choice == "camelcase")
    {
        for (int i = 0; i < splitedString.Length; i++)
        {
            string word = splitedString[i].ToLower();

            if (i == 0) output = word;
            else
            {
                string capitalised = char.ToUpper(word[0]) + (word.Substring(1));
                output = string.Concat(output, capitalised);
            }
        }
    }

    if (choice == "pascalcase")
    {

        for (int i = 0; i < splitedString.Length; i++)
        {
            string word = splitedString[i].ToLower();

            string capitalised = char.ToUpper(word[0]) + (word.Substring(1));
            output = string.Concat(output, capitalised);

        }
    }

    if (choice == "snake_case")
    {
        for (int i = 0; i < splitedString.Length; i++)
        {
            string word = splitedString[i];

            if (i == 0) output = word;
            else output = string.Concat(output, "_", word);
        }
    }

    return output;
}
Debug.Assert(VariableNameHelper("hello world", "snake_case") == "hello_world");
Debug.Assert(VariableNameHelper("hello world", "camelCase") == "helloWorld");
Debug.Assert(VariableNameHelper("hello world", "PascalCase") == "HelloWorld");