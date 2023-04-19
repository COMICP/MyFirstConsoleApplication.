// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
string name = "Jaden Binette";
string location = "Fredericksburg, VA";

Console.WriteLine($"My name is {name}");

Console.WriteLine($"My location is {location}");

DateTime date = DateTime.Now;
DateTime christmas = new DateTime(2023, 12, 25);

var tillChristmas = Math.Round((christmas - date).TotalDays, 0);

Console.WriteLine("Todays date is " + date.ToString("MM/dd/yyyy"));
Console.WriteLine($"there are {tillChristmas} days till christmas");


double width, height, woodLength, glassArea;

string widthString, heightString;

Console.WriteLine("What is the width of the window");
widthString = Console.ReadLine();
width = double.Parse(widthString);

Console.WriteLine("What is the height of the window");
heightString = Console.ReadLine();
height = double.Parse(heightString);


woodLength = 2 * (width + height) * 3.25;
glassArea = 2 * (width * height);


Console.WriteLine("The length of the wood is " +
woodLength + " feet");

Console.WriteLine("The area of the glass is " +
glassArea + " square metres");

Console.ReadKey();