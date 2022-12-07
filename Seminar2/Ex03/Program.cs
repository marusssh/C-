// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
//6, 7 - выходной.
//НО дня с индексом 0 или 12 не существует.
//6 -> да
//7 -> да
//1 -> нет

Console.WriteLine("Введите число, обозначающее день недели (1-понедельник, 2-вторник и т.д.): ");

int user_number = Convert.ToInt32(Console.ReadLine ());
string user_number_string = Convert.ToString (user_number);

if (user_number>5 && user_number<8)
    {
    Console.WriteLine("Выходной день");
    }
    
        if (user_number<6 && user_number>0)
        {
            Console.WriteLine("Будний день");
        }
        