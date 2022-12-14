int GetPower (int numberA,int numberB) {
    int result = 1;
    for (int i = 1; i <= numberB; i++) {
        result = result*numberA;
    }
    return result;
}

Console.Write("Введите число: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите степень: ");
int numberB = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(GetPower(numberA,numberB));