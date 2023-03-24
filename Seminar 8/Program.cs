Console.Clear();
Console.WriteLine("1 - Task 54");
Console.WriteLine("2 - Task 56");
Console.WriteLine("3 - Task 58");
int NumberOfTask = Prompt("Введите номер задачи");
switch(NumberOfTask)
{
    case 1:
    Console.Clear();
    Task54();
    break;

    case 2:
    Console.Clear();
    Task56();
    break;

    case 3:
    Console.Clear();
    Task58();
    break;

    default:
    Console.WriteLine("Номер задачи введен неверно");
    break;
    
}
    static int Prompt(string massage)//метод запроса числа
{
    Console.WriteLine(massage);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

static void Task54()
{ 
// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int[,] GetArray()
{
    int[,] array = new int[4,4];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.WriteLine();
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = new Random().Next(0,10);
            Console.Write($"{array[i,j]}" + "   ");
        }
    }
    Console.WriteLine("\n");
    return array;
}

void SorterInStrings(int[,] array)
{
    int[] oneStringArr = new int[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            oneStringArr[j] = array[i,j];
        }
        Array.Sort(oneStringArr);
        Array.Reverse(oneStringArr);
        Console.WriteLine(String.Join(" ", oneStringArr));
    }
}

int[,] array = GetArray();
SorterInStrings(array);
   
}

static void Task56()
{ 
// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке и 
// выдаёт номер строки с наименьшей суммой элементов: 1 строка

 int[,] GetArray()
{
    int[,] array = new int[new Random().Next(3,6), new Random().Next(3,6)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.WriteLine();
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = new Random().Next(0,10);
            Console.Write($"{array[i,j]}" + "   ");
        }
    }
    Console.WriteLine("\n");
    return array;
}

int[] Summary(int[,] array)          
{
    int[] arraySummary = new int[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            arraySummary[i] += array[i,j];
        }
    }
    return arraySummary;
}

void Compairison(int[] arraySummary)
{
    int minimalSummarise = arraySummary[0];
    int minimalIndex = 0;
    for (int i = 0; i < arraySummary.Length; i++)
    {
        if(minimalSummarise>arraySummary[i])
            {
                minimalSummarise = arraySummary[i];
                minimalIndex = i;
            }
    }
    System.Console.WriteLine($"The string with minimal summary: {minimalIndex + 1} string");
}

int[,] array = GetArray();
Compairison(Summary(array));
}

static void Task58()
{ 
// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int a = new Random().Next(3, 9);
int b = new Random().Next(3, 9);
int c = new Random().Next(3, 9);
int[,] firstMatrix = new int[a, b];
int[,] secondMatrix = new int[b, c];

int[,] GetMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.WriteLine();
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
            Console.Write($"{array[i, j]}" + "   ");
        }
    }
    Console.WriteLine("\n");
    return array;
}

int[,] MultiplicationMatrix(int[,] firstMatrix, int[,] secondMatrix, int a, int c)
{
    int[,] multiplicationMatrix = new int[a, c];
    for (int i = 0; i < firstMatrix.GetLength(0); i++)
    {
        Console.WriteLine();
        int multiplic = 0;
        for (int j = 0; j < secondMatrix.GetLength(1); j++)
        {
            int multiFunction = 0;
            for (int k = 0; k < firstMatrix.GetLength(1); k++)
            {
                multiplic = firstMatrix[i, k] * secondMatrix[k, j];
                multiFunction += multiplic;
            }
            multiplicationMatrix[i, j] = multiFunction;
            Console.Write($"{multiplicationMatrix[i, j]}" + "   ");
        }
    }
    return multiplicationMatrix;
}

Console.WriteLine("The first matrix is: ");
firstMatrix = GetMatrix(firstMatrix);
Console.WriteLine("The second matrix is: ");
secondMatrix = GetMatrix(secondMatrix);
MultiplicationMatrix(firstMatrix, secondMatrix, a, c);
}