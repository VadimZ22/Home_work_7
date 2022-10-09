/*Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4

1
7 -> такого числа в массиве нет*/

Console.Clear();
double[,] array = new double[6, 5];
FillArray(array);
PrintArray(array);

Console.Write("Введите первый индекс элемента: ");
int m = Convert.ToInt32(Console.ReadLine()!);
Console.Write("Введите второй индекс элемента: ");
int n = Convert.ToInt32(Console.ReadLine()!);

if (IsElement(array, m, n))
    Console.WriteLine(array[m, n]);
else
    Console.WriteLine("Нет такого элемента!");

 
 
void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]} ");
            
        }
        Console.WriteLine();
    }
}
 
  
void FillArray(double[,] array)
{
    
    Random rand = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = rand.Next(-10, 10);
        }
    }
}


bool IsElement(double[,] array, int i, int j)
{
    if (i >= array.GetLength(0) || j >= array.GetLength(1)
        || i < 0 || j < 0)
        return false;
    return true;
}