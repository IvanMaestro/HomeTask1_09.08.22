// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Введите первое число: ");
int firstnum = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int secondnum = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число: ");
int thirdnum = Convert.ToInt32(Console.ReadLine());

int max = firstnum;

if(secondnum > max) max = secondnum;
if(thirdnum > max) max = thirdnum;

Console.WriteLine($"Наибольшее число: {max}");