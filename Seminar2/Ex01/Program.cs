//Напишите программу, которая принимает на вход 
//трёхзначное число и на выходе показывает вторую 
//цифру этого числа.

//456 -> 5
//782 -> 8
//918 -> 1

Console.WriteLine("Введите трёхзначное число: ");

int user_number = Convert.ToInt32(Console.ReadLine ());

string user_number_string = Convert.ToString (user_number);

Console.WriteLine(user_number_string[1]);

