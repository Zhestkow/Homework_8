// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт 
// номер строки с наименьшей суммой элементов: 1 строка


using System;
using static System.Console;
Clear();
Write("Ввдеите количество строк, столбцов, минимальное и максимальное значение через пробел: ");
int[] parameters = GetArrayFromString(ReadLine()!);
int[,] matrix = GetMatrixArray(parameters[0], parameters[1], parameters[2], parameters[3]);
PrintMatrix(matrix);
WriteLine();
int K = parameters[3] * parameters[1];
int MinRow = 0;
for (int i = 0; i < matrix.GetLength(0); i++)
{
    int count = 0;
    for (int j = 0; j < matrix.GetLength(1); j++)
    {

        count += matrix[i, j];
    }
    if (count < K)
    {
        K = count;
        MinRow = i;
    }
}
Write($"строка № {MinRow + 1} с наименьшей суммой элементов {K}");







int[,] GetMatrixArray(int rows, int coloms, int minValue, int maxValue)
{
    int[,] MatrixArray = new int[rows, coloms];
    for (int i = 0; i < MatrixArray.GetLength(0); i++)
    {
        for (int j = 0; j < MatrixArray.GetLength(1); j++)
        {
            MatrixArray[i, j] = new Random().Next(minValue, maxValue);
        }
    }
    return MatrixArray;
}

int[] GetArrayFromString(string parameters)
{
    string[] parametr = parameters.Split(" ", StringSplitOptions.RemoveEmptyEntries);
    int[] parametrNum = new int[parametr.Length];
    for (int i = 0; i < parametrNum.Length; i++)
    {
        parametrNum[i] = int.Parse(parametr[i]);
    }
    return parametrNum;
}

void PrintMatrix(int[,] inMatrix)
{
    for (int i = 0; i < inMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < inMatrix.GetLength(1); j++)
        {
            Write($"{inMatrix[i, j]} ");
        }
        WriteLine();
    }
}


