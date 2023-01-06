﻿// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2

// 1 -3,3 8 -9,9

Console.WriteLine("Введите количество строк: ");

int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество столбцов:");

int n = Convert.ToInt32(Console.ReadLine());

double[,] UserArray = new double [m,n];
Random UsAr = new Random();

void FillRandom (double[,] array)
{
    for (int i = 0; i < m; i++)
    { 
        for (int j = 0; j < n; j++)
        {
        array[i, j] = Convert.ToDouble(new Random().Next(-10, 10)) / 10;
        }
    }
}

void PrintArray (double[,] array)
{
    for (int i = 0; i < m; i++)
    { 
        for (int j = 0; j < n; j++)
        { 
         Console.Write ($"{array[i, j]} ");
        }
        Console.WriteLine(" ");
    }
}

FillRandom(UserArray);
PrintArray(UserArray);