// Задача 60. 
// Сформируйте трёхмерный массив из неповторяющихся 
// двузначных чисел. Напишите программу, которая будет построчно 
// выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)


using static System.Console;
Clear();
int[,] matrix = GetMatrixArray(6, 6);
PrintMatrix(matrix);









int[,] GetMatrixArray(int rows, int coloms)
{
    int k = 0;
    int num = 1;
    int[,] MatrixArray = new int[rows, coloms];
    for (int i = 0; i < MatrixArray.GetLength(0); i++)
    {
        for (int j = 0; j < MatrixArray.GetLength(1); j++)
        {
            if (i % 2 == 0)
            {
                MatrixArray[i, k] = num;
                k++;
                num++;
            }
            else 
            {
                k--;
                MatrixArray[i, k] = num;
                num++;

            }
        }
        
    }return MatrixArray;
}

void PrintMatrix(int[,] inMatrix)
{
    for (int i = 0; i < inMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < inMatrix.GetLength(1); j++)
        {
            Write($"{inMatrix[i, j]}\t");
        }
        WriteLine();
    }
}





    