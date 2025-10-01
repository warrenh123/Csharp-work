//Exercise 1
static void waveFunction(string userInput)
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
waveFunction("hello");

//Exercise 2
string word = "hello 你好";
foreach (char c in word)
{
    int x = (int)c;
    Console.Write(x + " ");
}

