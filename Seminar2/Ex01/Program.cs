//Напишите программу, которая принимает на вход 
//трёхзначное число и на выходе показывает вторую 
//цифру этого числа.

//456 -> 5
//782 -> 8
//918 -> 1

Console.WriteLine("Введите трёхзначное число: ");

string number = Console.ReadLine();
int startIndex = 1;
int length = 1;

String second_number = number.Substring(startIndex, length);

Console.WriteLine(second_number);
