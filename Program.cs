Console.Write("Podaj liczbe: ");
string number = Console.ReadLine();
int n = Convert.ToInt32(number);
// int n = 33;
List<int> numbers = new List<int>();

Console.WriteLine();
Console.WriteLine("Liczby pierwsze:\n ");

for (int i = 2; i <= n; i++)
{
    if (i == 2 || i == 3 || i == 5)
    {
        Console.Write($"{i} ");
        numbers.Add(i);
    }
    else if (i % 2 != 0 && i % 3 != 0 && i % 5 != 0)
    {
        Console.Write($"{i} ");
        numbers.Add(i);
    }
}

Console.WriteLine();
Console.WriteLine("\nLiczby bliźniacze:\n ");

int lastNum = numbers.Last();
int skip = 0;

foreach (var item in numbers)
{
    skip++;
    var nextItem = numbers.Skip(skip).FirstOrDefault();
    if(nextItem >= lastNum)
        break;
    else if (nextItem - item == 2)
    {
        Console.Write($"[{item}, {nextItem}] ");
    }
}   

Console.WriteLine();
Console.WriteLine("\nLiczby czworacze:\n ");