// Задача 58: Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.

// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3

// Результирующая матрица будет:
// 18 20
// 15 18







using System;
using static System.Console;
Clear();
int[,] matrix1 = GetMatrixArray(3, 3, 1, 4);
PrintMatrix(matrix1);
WriteLine();
int[,] matrix2 = GetMatrixArray(3, 3, 1, 4);
PrintMatrix(matrix2);
WriteLine();
int[,] matrix3 = new int[matrix1.GetLength(0), matrix1.GetLength(1)];
for (int i = 0; i < matrix1.GetLength(0); i++)
{
    for (int j = 0; j < matrix1.GetLength(1); j++)
    {
        for (int k = 0; k < matrix1.GetLength(1); k++)
        {
            matrix3[i, j] += matrix1[i, k] * matrix2[k, j];
        }
    }
}
PrintMatrix(matrix3);




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


