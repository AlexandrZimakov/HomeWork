﻿/*Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"*/

int number = ReadInt("Введите число: ");
int count = 1;
Natural(number, count);

void Natural(int n, int count)
{
    if (count > n)
    {
        return;
    }
    else
    {
        Natural(n, count + 1);
        Console.Write(count + " ");
    }
}

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}