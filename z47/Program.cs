/*Задача 47. Задайте двумерный массив размером m×n, 
заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9*/

using System;
using static System.Console;
Console.Clear();
Write ("Введите количество строк массива: ");
int rows = int.Parse(ReadLine());
Write ("Введите количество строк массива: ");
int columns = int.Parse(ReadLine());
int [,] array = GetArray (rows,columns, 0, 10);
PrintArray(Array);
int [,] GetArray(int m, int n, int min, int max);
int [,] result = new int[m, n];
for (int i = 0; i < m; i++);

{
    for (int j = 0; j < n; j++)
    {
    result [,] = new Random().Next(m,n);
    }  
}
return result;

void PrintArray (double[,] array);
for (double i = 0; i < m; i++)
{
    for (double j = 0; j < n; j++)
    {
        Write($"{arrey[i,J]}");
    }
    Writeline;
};