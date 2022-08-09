// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.WriteLine("Введите первое число: ");
int firstnum = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int secondnum = Convert.ToInt32(Console.ReadLine());

int max = firstnum;

if (secondnum == max)
{
    Console.WriteLine("Числа равны");
}
else
{

    if (secondnum > max)
    {

        max = secondnum;
        Console.WriteLine($"Число {secondnum} больше числа {firstnum}");

    }

    else
    {

        max = firstnum;
        Console.WriteLine($"Число {firstnum} больше числа {secondnum}");
    }
    Console.WriteLine($"Наибольшим числом является {max}");
}