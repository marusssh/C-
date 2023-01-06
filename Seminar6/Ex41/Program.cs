// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

//0, 7, 8, -2, -2 -> 2

//1, -7, 567, 89, 223-> 3

Console.WriteLine("Введите M");

int Size = Convert.ToInt32(Console.ReadLine());

int[] Myarray = new int[Size];

Console.WriteLine("Введите массив:");

    for (int i = 0; i < Size; i++)
{
        Myarray[i] = Convert.ToInt32(Console.ReadLine());
}

int max = Myarray[0];

    for (int i = 0; i < Size; i++)
{
            if (Myarray[i] > max) 
            max = Myarray[i];

}
            

           
       



