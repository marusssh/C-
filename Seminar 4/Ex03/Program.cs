//  Задача 29: Напишите программу, которая задаёт массив из N элементов (из диапазона [0-14] ) 
//и выводит на экран десятичное представление числа, записанного в СС по основанию 15

//  N: 3 [9, 4, 12] => 2097
//  Для проверки можно использовать https://numsys.ru/convert/2097/10/15//


Console.WriteLine("N =  ");
int N = Convert.ToInt32 (Console.ReadLine ());
int size = N;
            int[] array = new int[N];
            Random myRandom = new Random();
 
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = myRandom.Next(0, 14);
                Console.WriteLine (array[i]);
            
            }

Console.WriteLine (Myliberary.ConvertTo15(array));

 
