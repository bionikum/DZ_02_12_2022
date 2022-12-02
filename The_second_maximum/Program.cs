Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int n1 = 1;
if (n > 99)
{
    while (n > 999 && !(n1 == 0))
    {
        n = n / 10;
        n1 = n % 10;
    }
}
    n = n / 100;
    n = n % 10;

    Console.WriteLine($"Значение второго максимума:  {n}");


