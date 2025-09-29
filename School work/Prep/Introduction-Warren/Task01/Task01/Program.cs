//two user inputs
Console.Write("Enter Minutes: ");
string inputMinutes = Console.ReadLine();
if (int.TryParse(inputMinutes, out int minutes))
{

}
else
{
    Console.WriteLine("That was not a valid number.");
}

Console.Write("Enter Seconds: ");
string inputSeconds = Console.ReadLine();
if (int.TryParse(inputSeconds, out int seconds))
{

}
else
{
    Console.WriteLine("That was not a valid number.");
}

//calculations
decimal hours = (decimal)minutes / 60m;
decimal speedMetresPerSecond = 10000m / (decimal)seconds;
decimal speedMilesPerHour = 6.21m / hours;

//round up to 2 d.p.
speedMetresPerSecond = Math.Round(speedMetresPerSecond, 2);
speedMilesPerHour = Math.Round(speedMilesPerHour, 2);

//result output
Console.WriteLine(@$"Your speed in m/s is {speedMetresPerSecond}.
Your speed in mph is {speedMilesPerHour}");