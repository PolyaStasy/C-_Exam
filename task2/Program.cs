//Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int Sum(int M, int N)
{
    if(N == M)
        return M;
    return Sum(M + 1, N) + M;
}

// --------------
System.Console.Write("Введите число: ");
int M = Convert.ToInt32(System.Console.ReadLine());
System.Console.Write("Введите число: ");
int N = Convert.ToInt32(System.Console.ReadLine());
System.Console.WriteLine(Sum(M, N));