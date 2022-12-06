/*Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет*/


Console.WriteLine("Введите число от 1 до 7 и узнаем,является выходным или нет");
int day = int.Parse(Console.ReadLine());
int dayOff = 6;
int dayOff1 = 7;
if(dayOff <= day && day <= dayOff1) {
    Console.WriteLine("Выходной");
} else {
    Console.WriteLine("Рабочий день");
}