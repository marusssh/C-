// //Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 17 -> такого числа в массиве нет

Console.WriteLine("Введите номер строки: ");

int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите номер столбца:");

int n = Convert.ToInt32(Console.ReadLine());

int [,] DoubleArray = new int [5,5];

void FillRandom (int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    { 
        for (int j = 0; j < array.GetLength(1); j++)
        {
        array[i, j] = new Random().Next(-10, 10);
        }
    }
}
 FillRandom(DoubleArray);
Console.WriteLine();

void PrintArray (int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    { 
        for (int j = 0; j < array.GetLength(1); j++)
        { 
         Console.Write ($"{array[i, j]} ");
        }
        Console.WriteLine(" ");
    }
}

PrintArray(DoubleArray);
Console.WriteLine();

if (n > DoubleArray.GetLength(0) | m > DoubleArray.GetLength(1))
    {
        Console.WriteLine ("-> такого числа в массиве нет");
    }
    else
    {
        Console.WriteLine ($"Значение элемента: {DoubleArray[n, m]}");
    }