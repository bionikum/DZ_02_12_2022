Console.Clear();
Console.Write("Введите число, соответствующее дню недели: ");
int n = Convert.ToInt32(Console.ReadLine());

if (n == 6 || n == 7)
{
    Console.WriteLine("Ура, выходной..!!!");
}
else if (n < 1 || n > 7)
{
    Console.WriteLine("День недели с таким номером не существует..");
}

else
{
    Console.WriteLine("Не является выходным...((");
}