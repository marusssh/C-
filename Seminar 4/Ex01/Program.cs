// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

//3, 5 -> 243 (3⁵)

//2, 4 -> 16

//НЕЛЬЗЯ ИСПОЛЬЗОВАТЬ Math.Pow

Console.WriteLine("A =  ");
int A = Convert.ToInt32 (Console.ReadLine ());

Console.WriteLine("B =  ");
int B = Convert.ToInt32 (Console.ReadLine ());

int m = 1;

for (int ind = 0; ind < B; m*=A, ind++) {
}

Console.WriteLine (m);
