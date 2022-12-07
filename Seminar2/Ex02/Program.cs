// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

//645 -> 5

//78 -> третьей цифры нет

//32679 -> 6
 
Console.WriteLine("Введите число: ");

int user_number = Convert.ToInt32(Console.ReadLine ());
string user_number_string = Convert.ToString (user_number);
if (user_number_string.Length > 2)
{
    Console.WriteLine(user_number_string[2]);
}
else
{
    Console.WriteLine("третьей цифры нет");
}

