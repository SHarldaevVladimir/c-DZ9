// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
int sum = 0;
int inputNumberM()
{
    Console.Write("Введите число M: ");
    int m = int.Parse(Console.ReadLine()!);
       return m;
}
int inputNumberN()
{
    Console.Write("Введите число N: ");
    int n = int.Parse(Console.ReadLine()!);
    return n;
}
int sumNumber(int m, int n)
{
if (m>n) return sum;
   sum += m;
sumNumber(m+1,n);      
return sum;
}

Console.WriteLine("Сумма чиселт от M до N: "+ sumNumber(inputNumberM(),inputNumberN())!);