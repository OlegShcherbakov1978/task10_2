// Задача 10: Напишите программу, которая принимает
// на вход трёхзначное число и на выходе показывает вторую цифру
// этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

// Решение 2

begin:

Console.Write("Введите трехзначное число: ");
int a = Convert.ToInt32(Console.ReadLine());

if (a < 100 || a > 999)
{
    System.Console.WriteLine("неверный ввод");
    goto begin;
}
else
{
    System.Console.WriteLine((a / 10) % 10);
}
