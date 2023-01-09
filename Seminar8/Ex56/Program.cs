// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int[,] UserArray = new int[4, 4];

void FillRandom(int[,] array)
{
    int sizeM = array.GetLength(0);
    int sizeN = array.GetLength(1);
    for (int i = 0; i < sizeM; i++)
    {
        for (int j = 0; j < sizeN; j++)
        {
            array[i, j] = new Random().Next(0, 9);
        }
    }
}

FillRandom(UserArray);

void PrintArray(int[,] array)
{
    int sizeM = array.GetLength(0);
    int sizeN = array.GetLength(1);
    for (int i = 0; i < sizeM; i++)
    {
        for (int j = 0; j < sizeN; j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine(" ");
    }
}

PrintArray(UserArray);
Console.WriteLine();

int sizeM = UserArray.GetLength(0);
int sizeN = UserArray.GetLength(1);

int SumRow(int[,] array, int i)
{
    int summa = array[i, 0];
    int sizeN = array.GetLength(1);
    for (int j = 1; j < sizeN; j++)
    {
        summa = summa + array[i, j];
    }
    return summa;
}

int minIndex = 0;
int minSummaRow = SumRow(UserArray, 0);
for (int i = 1; i < sizeM; i++)
{
    int tempSum = SumRow(UserArray, i);
    if (minSummaRow > tempSum)
    {
        minSummaRow = tempSum;
        minIndex = i;
    }
}

Console.Write($"Минимальная сумма: {minSummaRow}; Строка: {minIndex+1} ");   
