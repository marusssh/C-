// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

//14212 -> нет

//12821 -> да

//23432 -> да


int a;
int b;
int beg;  
int end=0;
Console.Write("Введите число: "); 

a = Convert.ToInt32(Console.ReadLine ());  
          beg=a;      
          while(a>0)      
          {      
           b=a%10;      
           end=(end*10)+b;      
           a=a/10;      
          }      
          if(beg==end)      
           Console.Write("Число - полиндром");      
          else      
           Console.Write("Число не является полиндромом");    