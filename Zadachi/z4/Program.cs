/* Задача 39: Напишите программу, которая перевернёт одномерный массив
 (последний элемент будет на первом месте, а первый - на последнем и т.д.)
[1 2 3 4 5] -> [5 4 3 2 1]
[6 7 3 6] -> [6 3 7 6] 


int a = 5;
int b = 6;
int tmp = a;
a = b;
b = tmp;*/

int[] array = new int[5] { 1, 2, 3, 4, 5 };

Reverse(array);
PrintArray(array);

void PrintArray(int[] array)
{
    Console.WriteLine(string.Join(",", array));
}

void Reverse(int[] array)
{
    int tmp;
    for (var i = 0; i <array.Length / 2; i++)
    {
        tmp = array[i];
        array[i] = array[array.Length - 1 - i];
        array[array.Length - 1 - i] = tmp;
    }
}