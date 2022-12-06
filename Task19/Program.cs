// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом
using System;
{
Console.Write("Введите пятизначное число: ");
string? num = Console.ReadLine();

void CheckNum(string number)
{
    if (num[0] == num[4] || num[1] == num[3])
    {
        Console.WriteLine($"Введенное число: {num} - палиндром.");
    }
    else Console.WriteLine($"Введенное число: {num} - не является палиндром.");
    }

    if (num!.Length == 5)
    {
        CheckNum(num);
    }
    else Console.WriteLine($"Введено неверное число");

    Console.ReadKey();
}