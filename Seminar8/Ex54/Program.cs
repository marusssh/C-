// Задача 54: Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

Console.WriteLine("Введите количество строк: ");

int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество столбцов:");

int n = Convert.ToInt32(Console.ReadLine());

int[,] UserArray = new int[m, n];

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
Console.WriteLine();

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

void Sort(int[,] array)
{
    int sizeM = array.GetLength(0); //строки 
    int sizeN = array.GetLength(1); // столбцы 

    for (int i = 0; i < sizeM; i++)
    {
        for (int j = 0; j < sizeN; j++)
        {
            for (int t = j + 1; t < sizeN; t++)
            {
                if (array[i,t] > array[i,j])
                {
                    int temp = array[i,j];
                    array[i,j] = array[i,t];
                    array[i,t] = temp;
                }
            }
        }
    }
}

Sort(UserArray);
PrintArray(UserArray);
