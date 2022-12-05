/*Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8*/

Console.Write("Введите число:");
int N = int.Parse(Console.ReadLine());
int value = 1;

while (value <= N) {
    if (value % 2 == 0) {
        Console.Write(value + " ");
    }
    value++;
}
Console.WriteLine();