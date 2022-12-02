Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());


if (n < 100)
{
    Console.WriteLine("Вы ввели не подходящее число");

}
else if (n > 999)
{
    while (n > 999)
    {
        n = n / 10;
    }

    int n1 = n % 10;
    Console.WriteLine($"Третья цифра введенного числа: {n1}");
}