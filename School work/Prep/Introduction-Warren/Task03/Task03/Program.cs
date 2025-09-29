// if choice is radius
Console.Write("Which value (a, r, c) do you want to enter?");
string choice = Console.ReadLine();

if (choice == "r")
{
    Console.Write("Enter radius: ");
    string input = Console.ReadLine();

    if (int.TryParse(input, out int radiusInInteger))
    {
        double radiusInDouble = Convert.ToDouble(radiusInInteger);

        double radiusSquared = Math.Pow(radiusInDouble, 2);

        double area = 3.14 * radiusSquared;
        double areaRounded = Math.Round(area, 2);

        double circumference = 3.14 * 2.0 * radiusInDouble;
        double circumferenceRounded = Math.Round(circumference, 2);

        Console.WriteLine($"Area is {areaRounded} and circumference is {circumferenceRounded}.");
    }
    else
    {
        Console.WriteLine("Please enter a valid value.");
    }
}

// if choice is area
else if (choice == "a")
{
    Console.Write("Enter area: ");
    string input = Console.ReadLine();

    if (int.TryParse(input, out int areaInInteger))
    {
        double areaInDouble = Convert.ToDouble(areaInInteger);

        double x = areaInDouble / 3.14;
        double radius = Math.Pow(x, 1.0 / 2.0);
        double radiusRounded = Math.Round(radius, 2);

        double circumference = radius * 2.0 * 3.14;
        double circumferenceRounded = Math.Round(circumference, 2);

        Console.WriteLine($"Radius is {radiusRounded} and circumference is {circumferenceRounded}.");

    }
    else
    {
        Console.WriteLine("Please enter a valid value.");
    }
}

// if choice is circumference
else if (choice == "c")
{
    Console.Write("Enter circumference: ");
    string input = Console.ReadLine();

    if (int.TryParse(input, out int circumferenceInInteger))
    {
        double circumferenceInDouble = Convert.ToDouble(circumferenceInInteger);

        double radius = circumferenceInDouble / (2.0 * 3.14);
        double radiusRounded = Math.Round(radius, 2);

        double radiusSquared = Math.Pow(radius, 2);
        double area = 3.14 * radiusSquared;
        double areaRounded = Math.Round(area, 2);

        Console.WriteLine($"Radius was {radiusRounded} and area was {areaRounded}.");
    }
}

// if none of the letters were input
else
{
    Console.WriteLine("Response was invalid");
}