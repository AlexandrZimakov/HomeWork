/*Задача 19Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да*/

Console.WriteLine("Введите пятизначное число:");
int number =int.Parse(Console.ReadLine());

if (isPolindrom(number)) {
    Console.WriteLine("Ваше число - палиндром.");
} else {
    Console.WriteLine("Выше число - НЕ палиндром.");
}
bool isPolindrom(int number) {
    int[] array = new int[5];
    for (int i = 0; i < 5; i++) {
        array [i] = number % 10;
        number = number / 10;
    }
    if (   array[0] == array[4]
        && array[1] == array [3] ) {
            return true;
        }
        else {
            return false;
        }
}