/*Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет*/
Console.WriteLine("Введите индекс строки: ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите индекс столбца: ");
int n = int.Parse(Console.ReadLine());
int[,] numbers = new int[3, 4];
FillArray(numbers);
PrintArray(numbers);

if (m < numbers.GetLength(0) && n < numbers.GetLength(1)){
    Console.WriteLine(numbers[m, n]);
} else {
    Console.WriteLine($"{m},{n} -> такого элемента нет");
}


void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}