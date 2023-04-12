Console.WriteLine("Введите число: ");
string text = Console.ReadLine();
int number = Convert.ToInt32(text);
int GetRank(int n)
{
    while (n > 999)
    {
        n = n / 10;

    }
    return n % 10;
}
if (number >= 1000)
{
    int m = GetRank(number);
    Console.Write(m);
}
if (number > 100 && number < 1000)

{
    int c = number % 10;
    Console.WriteLine($"{c}");
}

if (number < 100)
{
    Console.WriteLine("третей цифры нет");

}






