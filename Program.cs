Console.WriteLine("Podaj liczbe: ");
string number = Console.ReadLine();
int n = Convert.ToInt32(number);
int[] numbers = new int[] { };

Console.WriteLine("Liczby pierwsze: ");

for (int i = 2; i <= n; i++)
{
    if (i == 2 || i == 3 || i == 5)
        Console.WriteLine(i);
    else if (i % 2 != 0 && i % 3 != 0 && i % 5 != 0)
        Console.WriteLine(i);
        numbers = numbers.Concat(new int[] { i }).ToArray();
}

Console.WriteLine("Liczby bliźniacze: ");
int lastNum = numbers.Last();

foreach (var item in numbers)
{
    var nextItem = numbers.SkipWhile(x => x != item).Skip(1).DefaultIfEmpty(numbers[0]).FirstOrDefault();
    if(nextItem >= lastNum)
        break;
    else if (nextItem - item == 2)
        Console.WriteLine(item);
}   

// try
// {
//     for (int i = 2; i < lastNum; i++)
//     { 
//         if (numbers[i + 2] >= lastNum)
//             break;
//         if (i == 2 || i == 3 || i == 5)
//             Console.WriteLine(i);
//         else if (i % 2 != 0 && i % 3 != 0 && i % 5 != 0)
//             if (numbers[i + 2] - numbers[i] == 2)
//                 Console.WriteLine(i);
//     }       
// }
// catch (IndexOutOfRangeException e)
// {
//     Console.WriteLine(e.Message);
// }

Console.WriteLine("Liczby czworacze: ");