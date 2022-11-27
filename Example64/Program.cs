// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

int printNumber(int N)
{
    if (N == 0) return 0;
    if (N == 1) Console.Write($"{N}");
    else
    {
        Console.Write($"{N}, ");
        printNumber(N - 1);
    }
    return 0;

}
printNumber(8);