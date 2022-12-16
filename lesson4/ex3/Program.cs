/*Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

6, 1, 33 -> [6, 1, 33] */


void AllArray(int[] massiv){
    int index = 0;
    while (index < massiv.Length){
        massiv[index] = new Random().Next(0,100);
        index++;
    }
}

void ArrayWrite(int[] massiv){
    int index = 0;
    Console.Write("[ ");
    while (index < massiv.Length){
        Console.Write($"{massiv[index]}");
        index++;
        if(index < massiv.Length) {
            Console.Write(", ");
        }
    }
    Console.Write(" ]");
    Console.WriteLine();
}


int[] array = new int[8];

AllArray(array);
ArrayWrite(array);