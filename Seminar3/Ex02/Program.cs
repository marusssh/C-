// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

//A (0,0); B (1,1), -> ~1.4

//A (2,4); B (0,7) -> ~3.6


Console.WriteLine("Координаты первой точки.");

Console.WriteLine("X1 =  ");
int X1 = Convert.ToInt32 (Console.ReadLine ());

Console.WriteLine("Y1 =  ");
int Y1 = Convert.ToInt32 (Console.ReadLine ());

Console.WriteLine("Координаты второй точки.");

Console.WriteLine("X2 =  ");
int X2 = Convert.ToInt32 (Console.ReadLine ());

Console.WriteLine("Y2 =  ");
int Y2 = Convert.ToInt32 (Console.ReadLine ());

int d1 = X2-X1;
int d2 = Y2-Y1;

double a = Math.Pow(d1,2);

double b = Math.Pow(d2,2);

double sum = a+b;

Console.WriteLine(Math.Sqrt(sum));
