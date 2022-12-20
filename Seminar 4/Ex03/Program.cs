//  Задача 29: Напишите программу, которая задаёт массив из N элементов (из диапазона [0-14] ) 
//и выводит на экран десятичное представление числа, записанного в СС по основанию 15

//  N: 3 [9, 4, 12] => 2097
//  Для проверки можно использовать https://numsys.ru/convert/2097/10/15//


int Pow (int a, int b)
{
    int result = 1;
    for (int i = 0; i<b; i++)
    {
        result = result * a;
    }
    return result;
}

int ConvertTo15 (int[] value)

{
    int result =0;
    int count =value.Length;
    for (int i = 0; i < count; i++)
    {
        result += value[i] * Pow(15, count -1 -i);
    }
    return result;
}

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

Console.WriteLine (ConvertTo15(array));

 
