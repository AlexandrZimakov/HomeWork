/* Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11

82 -> 10

9012 -> 12*/


int GetSum(int number){
    int sumNumber = 0;

    while (number > 0){
        sumNumber += number % 10;
        number /= 10;
    }
    return sumNumber;
}

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(GetSum(number));