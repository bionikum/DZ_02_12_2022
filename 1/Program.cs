Console.Clear();
Console.WriteLine("Введите числа: ");
int n = Convert.ToInt32(Console.ReadLine());
int i = 0;
int x = 0;
while (n != 0 && i < 100)
{
    n = Convert.ToInt32(Console.ReadLine());
    i = i + n;
    while (i < i + n)
    {
        n = Convert.ToInt32(Console.ReadLine());
       
    }

}

Console.WriteLine($"Значение второго максимума: {i}");
