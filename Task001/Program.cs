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
    int result = 1;
    for (int i = 0; i < degreeNumber; i++)
    {
        result *= num;
    }
    return result;
}

bool ValidateDegree(int degree)
{
    if (degree < 0)
    {
        Console.WriteLine("Степень не должна быть меньше нуля");
        return false;
    }
    return true;
}

(int number, int degreeNumber) userNumber = InputUserNumberDegree();
if (ValidateDegree(userNumber.degreeNumber))
{
    Console.WriteLine($"Число {userNumber.number} в степени {userNumber.degreeNumber} = {DegreeNumber(userNumber.number, userNumber.degreeNumber)}");
}
