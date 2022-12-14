// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
//Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

Console.WriteLine("Введите количество x: ");

int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество y:");

int y = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество z: ");

int z = Convert.ToInt32(Console.ReadLine());


int[, ,] UserArray = new int[x, y, z];

void FillRandom(int[, ,] array)
{
    int sizeX = array.GetLength(0);
    int sizeY = array.GetLength(1);
    int sizeZ = array.GetLength(2);

    for (int i = 0; i < sizeX; i++)
    {
        for (int j = 0; j < sizeY; j++)
        {
            for (int k = 0; k < sizeZ; k++)

            array[i, j, k] = new Random().Next(10, 99);
        }
    }
}

FillRandom(UserArray);

void PrintArray(int[, ,] array)
{
    
    int sizeX = array.GetLength(0);
    int sizeY = array.GetLength(1);
    int sizeZ = array.GetLength(2);
    for (int i = 0; i < sizeX; i++)
    {
        for (int j = 0; j < sizeY; j++)
        {
            for (int k = 0; k < sizeZ; k++)
        {
            Console.Write($"{array[i, j, k]}({i}, {j}, {k}) ");
        }
    }
        Console.WriteLine(" ");
    }
}


PrintArray(UserArray);
