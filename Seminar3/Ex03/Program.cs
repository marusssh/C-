// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125

//int a;
//int b;
//int beg;  
//int end=0;
//Console.Write("Введите число: "); 

//a = Convert.ToInt32(Console.ReadLine ());  
          //beg=a;      
          //while(a>0)      
          //{      
           //b=a%10;      
           //end=(end*10)+b;      
          // a=a/10;      
      //    }      
       //   if(beg==end)      
     //      Console.Write("Число - полиндром");      
    //      else      
    //       Console.Write("Число не является полиндромом");    

Console.Write("Введите число: "); 

double n = Convert.ToDouble (Console.ReadLine());

double a = 1;
while (n>=a)
{
    double c = Math.Pow(a,3); 
    Console.WriteLine("{0,10}|{1,10}", a,c);
    a++;
}