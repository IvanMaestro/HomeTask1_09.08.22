// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Write("Введите любое число: ");
int num = Convert.ToInt32(Console.ReadLine());



int count = 0;

Console.WriteLine($"Четные числа от 1 до {num}: ");

for (count = 1; count <= num; count++)
{

    if (count % 2 == 0) Console.Write(count);

    else
    {
        Console.Write(" ");
    }

}

