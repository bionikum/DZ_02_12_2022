Console.Clear();
Console.Write("Введите трехзначное число: ");
int n = Convert.ToInt32(Console.ReadLine());


if (n < 100 || n > 999)
{
    Console.WriteLine("Вы ввели не трехзначное число");
}
else
{
    int n1 = n % 100;
    int n2 = n1 / 10;
    Console.WriteLine($"Вторая цифра введенного числа: {n2}");
}


