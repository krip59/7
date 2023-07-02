/*Задача 50. Напишите программу, которая на вход 
принимает позиции элемента в двумерном массиве, и 
возвращает значение этого элемента или же указание, 
что такого элемента нет.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет*/

using System;
using static System.Console;
Console.Clear();
Write ("Введите количество строк массива: ");
int rows = int.Parse(ReadLine());
Write ("Введите количество строк массива: ");
int columns = int.Parse(ReadLine());
Write ("Введите число: ");
int m = int.Parse(ReadLine());
 
int [,] array = GetArray (rows,columns, 0, 10);
PrintArray(Array);

int[,] GetArray(int a, int b); 
int[,] result = new int (m,n);
for (Int i = 0; i < a; i++)
{ for (int j = 0; j < b; j++)
    {
        result[i,j] = new Random().Next(m,n);
    }      
 return result;  
}
int[,] GetArray(int a, int b); 
for (int i = 0; i < rows ; i++)
{
   
    for (int j = 0; j < columns ; j++)
    {  m = GetArray [i,j];
    Write("Такое число есть");
    }
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