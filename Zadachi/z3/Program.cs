/*Задача No22. Работа в группах
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел
от 1 до N.
● 5 -> 1, 4, 9, 16, 25.
● 2 -> 1,4*/

int num = int.Parse(Console.ReadLine());
int[] arr = GetNumbers(num);

PrintArray(arr);

int[] GetNumbers(int N) {
    int[] array = new int [N];
    for (int i = 0; i < N; i++) {
        array[i] = (i + 1) * (i + 1);
    }
    return array;
}

void PrintArray(int[] array) {
    for (int i = 0; i < array.Length; i++){
        Console.WriteLine(array[i]);
    }
}