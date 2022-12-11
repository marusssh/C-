// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

//452 -> 11

//82 -> 10

//9012 -> 12

//Строки использовать нельзя


Console.WriteLine("Введите число: "); 

int a = Convert.ToInt32(Console.ReadLine ());

int b= a%10;

int sum = 0;

while (a > 0) 
{
    sum += b;
    a=a/10;
    b=a%10;
}     

Console.WriteLine(sum);
