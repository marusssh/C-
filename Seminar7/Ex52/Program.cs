//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.WriteLine("Введите количество строк: ");

int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество столбцов:");

int n = Convert.ToInt32(Console.ReadLine());

int [,] UserArray = new int [m,n];


void FillRandom (int[,] array)
{
    for (int i = 0; i < m; i++)
    { 
        for (int j = 0; j < n; j++)
        {
        array[i, j] = new Random().Next(-10, 10);
        }
    }
}
FillRandom(UserArray);

void PrintArray (int[,] array)
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
PrintArray(UserArray);
Console.WriteLine();

for (int j = 0; j < UserArray.GetLength(1); j++)
{
    double ArithMean = 0;
    for (int i = 0; i < UserArray.GetLength(0); i++)
    {
        ArithMean = (ArithMean + UserArray[i,j]);
    }
    ArithMean = ArithMean / m;
    Console.Write($" {ArithMean}; ");
}
