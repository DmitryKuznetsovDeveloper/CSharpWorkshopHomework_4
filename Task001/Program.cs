// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

(int, int) InputUserNumberDegree() // Метод Получения числа и степени
{
    Console.Write($"Введите число  --> ");
    int number = Convert.ToInt32(Console.ReadLine());
    Console.Write($"Введите степень в которую хотите возвести число  --> ");
    int degreeNumber = Convert.ToInt32(Console.ReadLine());
    return (number, degreeNumber);
}

int DegreeNumber(int num, int degreeNumber) // Метод возведения в степень
{
    int result = num;
    for (int i = 1; i < degreeNumber; i++)
    {
        result *= num;
    }
    return result;
}

(int number, int degreeNumber) userNumber = InputUserNumberDegree();
Console.WriteLine($"Число {userNumber.number} в степени {userNumber.degreeNumber} = {DegreeNumber(userNumber.number, userNumber.degreeNumber)}");
