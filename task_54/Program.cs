// Задача 54: Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки двумерного массива.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

using System;
using static System.Console;
Clear();
Write("Ввдеите количество строк, столбцов, минимальное и максимальное значение через пробел: ");
int[] parameters = GetArrayFromString(ReadLine()!);
int[,] matrix = GetMatrixArray(parameters[0], parameters[1], parameters[2], parameters[3]);
PrintMatrix(matrix);
WriteLine();
PrintMatrix(SortMtx(matrix));



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




int[,] SortMtx(int[,] NewMatrix)
{ 
for (int i = 0; i < NewMatrix.GetLength(0); i++)
{
    for (int j = 0; j < NewMatrix.GetLength(1) - 1; j++)
    {
        for (int k = 0; k < NewMatrix.GetLength(1) - 1; k++)
        {
            if (NewMatrix[i, k] < NewMatrix[i, k + 1]) 
            {
                int temp = 0;
                temp = NewMatrix[i, k];
                NewMatrix[i, k] = NewMatrix[i, k + 1];
                NewMatrix[i, k + 1] = temp;
            }
        }
    }
}
return NewMatrix;
}





