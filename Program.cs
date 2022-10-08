Console.Write("Podaj liczbe: ");
string number = Console.ReadLine();
int n = Convert.ToInt32(number);

List<int> numbers = new List<int>();
List<int> twinNumbers = new List<int>();

Console.WriteLine();
Console.WriteLine("Liczby pierwsze:\n ");

bool isPrime = false;

for (int i = 2; i <= n; i++)
{
    for (int j = 2; j < i; j++)
    {
        if (i % j == 0)
        {
            isPrime = false;
            break;
        }
        else
        {
            isPrime = true;
        }
 
    }
    
    if (isPrime == true)
    {
        Console.Write(i + " ");
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
        twinNumbers.Add(item);
        twinNumbers.Add(nextItem);
    }
}   

Console.WriteLine();
Console.WriteLine("\nLiczby czworacze:\n ");

int skip2 = 0;
int skip3 = 1;
int skip4 = 2;
int lastTwinNum = twinNumbers.Last();

foreach (var item in twinNumbers)
{
    skip2++;
    skip3++;
    skip4++;
    var nextItem = twinNumbers.Skip(skip2).FirstOrDefault();
    var nextItem2 = twinNumbers.Skip(skip3).FirstOrDefault();
    var nextItem3 = twinNumbers.Skip(skip4).FirstOrDefault();

    if(nextItem3 >= lastTwinNum)
        break;
    else if(nextItem2 - item == 6 && nextItem3 - item == 8)
        Console.Write($"[{item}, {nextItem}, {nextItem2}, {nextItem3}] ");
}   