// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int InputUser(string msg)
{
    System.Console.Write($"{msg}  --> ");
    int userNumber = Convert.ToInt32(Console.ReadLine());
    return userNumber;
}

void FillArray(int[] array, int minNumber, int maxNumber)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(minNumber, maxNumber + 1);
    }
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}, ");
        if (i == array.Length - 1) Console.Write($"{array[i]}.");
    }
}

int userNumber = InputUser("Введите количесво элементов в массиве");
int minNumber = InputUser("Введите минимальное значение массива");
int maxNumber = InputUser("Введите максимальное значение массива");
int[] myArray = new int[userNumber];
FillArray(myArray, minNumber, maxNumber);
PrintArray(myArray);