﻿// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Введите натуральное число M: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите натуральное число N: ");
int n = Convert.ToInt32(Console.ReadLine());


int Sum(int i, int j)
{

    if (i == j)
        return j;
    return j + Sum(i, j - 1);
}

Console.WriteLine($"Сумма элементов от {m} до {n} = {Sum(m,n)}");
