long total = 0;
string[] lines = File.ReadAllLines("C:\\Users\\Lungelo\\source\\repos\\ConsoleApp2\\ConsoleApp2\\Input.txt");

foreach (var line in lines)
{
    int firstDigit = line.First(c => char.IsDigit(c)) - '0';
    int lastDigit = line.Last(c => char.IsDigit(c)) - '0';

    var fullNumber = firstDigit * 10 + lastDigit;
    total += fullNumber;
}

Console.WriteLine(total);
Console.ReadLine();