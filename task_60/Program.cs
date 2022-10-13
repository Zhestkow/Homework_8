
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
int[,,] matrix = GetMatrixArray(3, 3, 3);
PrintMatrix(matrix);








int[,,] GetMatrixArray(int n, int l, int h)
{
    int idx = 0;
    int temp = 0;
    int z = 0;
    int x = n * l * h;
    int[] arr1 = new int[x];
    int[,,] MatrixArray = new int[n, l, h];
    for (int i = 0; i < MatrixArray.GetLength(0); i++)
    {
        for (int j = 0; j < MatrixArray.GetLength(1); j++)
        {
            for (int k = 0; k < MatrixArray.GetLength(2); k++)
            {
                limb:
                temp = new Random().Next(11, 100);
                
                if (arr1.Contains(temp))
                {
                    goto limb;
                }
                else
                {
                    MatrixArray[i, j, k] = temp;
                    arr1[z] = temp;
                    z++;
                }
            }
        }
    }return MatrixArray;
}




void PrintMatrix(int[,,] inMatrix)
{
    for (int i = 0; i < inMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < inMatrix.GetLength(1); j++)
        {
            for (int k = 0; k < inMatrix.GetLength(2); k++)
            {
                Write($"{inMatrix[i, j, k]}{(i, j, k)}\t");
            }
            WriteLine();
        }
        WriteLine();
    }
}
























// Этот вариант запасной) просто попорядку числа ставит)


// using static System.Console;
// Clear();
// int[,,] matrix = GetMatrixArray(4, 4, 4);
// PrintMatrix(matrix);


// int[,,] GetMatrixArray(int x, int y, int z)
// {
//     int num=10;
//     int[,,] MatrixArray = new int[x, y, z];
//     for (int i = 0; i < MatrixArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < MatrixArray.GetLength(1); j++)
//         {
//             for (int k = 0; k < MatrixArray.GetLength(2); k++)
//             {
//                 MatrixArray[i, j, k] = num;
//                 num++;
//             }
//         }
//         }
//     return MatrixArray;
// }


// void PrintMatrix(int[,,] inMatrix)
// {
//     for (int i = 0; i < inMatrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < inMatrix.GetLength(1); j++)
//         {
//             for (int k = 0; k < inMatrix.GetLength(2); k++)
//             {
//                 Write($"{inMatrix[i, j, k]} {(i,j,k)}\t");
//             }
//             WriteLine();
//         }
//         WriteLine();
//     }
// }