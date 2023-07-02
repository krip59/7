/*Задача 52. Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.*/
using System;
using static System.Console;
Console.Clear();
Write ("Введите количество строк массива: ");
double rows = double.Parse(ReadLine());
Write ("Введите количество строк массива: ");
double columns = int.Parse(ReadLine());
double [,] array = GetArray (rows,columns, 0, 10);
PrintArray(Array);
double [,] GetArray(double m, double n, double min, double max);
double [,] result = new double[m, n];
for (double i = 0; i < m; i++)
{ for (double j = 0; j < n; j++)
    
      double[,] IntArray = new double[a,b];
   
}
double[,] GetArray(double a, double b); 
for (double i = 0; i < a; i++)
{
   
    for (double j = 0; j < b; j++)
    {  Double sum=0;
        sum=sum+n(j);
        
    }
    Console.Write(Sum=Sum/(b+1));
}

void PrintArray (double[,] array);
for (double i = 0; i < m; i++)
{
    for (double j = 0; j < n; j++)
    {
        Write($"{arrey[i,J]}");
    }
    Writeline;
};