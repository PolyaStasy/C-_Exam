﻿// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

string f(int N)
{
    if(N == 1)
        return $"{1}";
    return $"{N}, " + f(N-1) ;
}

// ---------------

System.Console.Write("Введите число: ");
int N = Convert.ToInt32(System.Console.ReadLine());
System.Console.WriteLine(f(N));
