Console.WriteLine("Podaj liczbe: ");
string number = Console.ReadLine();
int n = Convert.ToInt32(number);

Console.WriteLine("Liczby pierwsze: ");

for (int i = 0; i <= n; i++)
{
    if (i % 2 != 0 && i > 1)
     Console.WriteLine(i);
}

Console.WriteLine("Liczby bliźniacze: ");

Console.WriteLine("Liczby czworacze: ");