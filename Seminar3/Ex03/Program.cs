// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125

Console.Write("Введите число: "); 

double n = Convert.ToDouble (Console.ReadLine());

double a = 1;
while (n>=a)
{
    double c = Math.Pow(a,3); 
    Console.WriteLine("{0,10}|{1,10}", a,c);
    a++;
}