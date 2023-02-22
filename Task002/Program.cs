// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
int InputUser(string msg)
{
    System.Console.Write($"{msg}  --> ");
    int userNumber = Convert.ToInt32(Console.ReadLine());
    return userNumber;
}

int SumDigitNumbers(int num) // Метод подсчета цифр в числе
{
    int result = 0;  // объявляем и инициализируем переменную в которую будем класть результат
    while (num > 0)  // цикл перебора числа
    {
        int digit = num % 10; // получаем последнюю цифру числа и кладем ее в переменную
        num /= 10;           //  отсекаем последнюю цифру числа
        result += digit;     //  складываем цифру в переменную 
    }
    return result;          // возвращаем значение
}

int userNumber = InputUser("Введите число из которово мы посчитаем сумму цифр");
Console.WriteLine($"В числе {userNumber} сумма цифр = {SumDigitNumbers(userNumber)}");