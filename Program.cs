// See https://aka.ms/new-console-template for more information
string response;
Console.WriteLine("What's your name");
response = Console.ReadLine();
Console.WriteLine($"Enjoy the course, {response}");

OperatingSystem thisOs = Environment.OSVersion;
Console.WriteLine(thisOs.VersionString);


