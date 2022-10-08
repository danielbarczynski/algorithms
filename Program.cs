Console.WriteLine("Podaj liczbe: ");
string number = Console.ReadLine();
int n = Convert.ToInt32(number);
// int n = 33;
List<int> numbers = new List<int>();

Console.WriteLine("Liczby pierwsze: ");

for (int i = 2; i <= n; i++)
{
    if (i == 2 || i == 3 || i == 5)
    {
        Console.WriteLine(i);
        numbers.Add(i);
    }
    else if (i % 2 != 0 && i % 3 != 0 && i % 5 != 0)
    {
        Console.WriteLine(i);
        numbers.Add(i);
    }
}

Console.WriteLine("Liczby bliźniacze: ");

int lastNum = numbers.Last();
int skip = 0;
int increment = 1;

foreach (var item in numbers)
{
    skip += increment;
    var nextItem = numbers.Skip(skip).FirstOrDefault();
    if(nextItem >= lastNum)
        break;
    else if (nextItem - item == 2)
    {
        Console.WriteLine($"{item}, {nextItem}");
    }
}   

Console.WriteLine("Liczby czworacze: ");