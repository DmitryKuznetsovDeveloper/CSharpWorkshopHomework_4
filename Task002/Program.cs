// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
int InputUserNumber() // Метод Получения числа 
{
    Console.Write($"Введите число  --> ");
    return Convert.ToInt32(Console.ReadLine());
}

int SumDigitNumbers(int num)
{
    int result = 0;
    while (num > 0)
    {
        int digit = num % 10;
        num /= 10;
        result += digit;
    }
    return result;
}

int userNumber = InputUserNumber();
Console.WriteLine($"В числе {userNumber} сумма цифр = {SumDigitNumbers(userNumber)}");