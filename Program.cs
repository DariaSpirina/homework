Console.Write("Введите первое число: ");
int numberA = int.Parse(Console.ReadLine()!);
Console.Write("Введите второе число: ");
int numberB = int.Parse(Console.ReadLine()!);
if (numberA < numberB)
{
    Console.WriteLine($"Наибольшее число {numberB}, а наименьшее число {numberA}");
}
else
{
    Console.WriteLine($"Наибольшее число {numberA}, а наименьшее число {numberB}");
}
