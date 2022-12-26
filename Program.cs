// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2



// int[,] CreateRandom2dArray(int rows, int cols, int min, int max)
// {
//     int[,] array = new int[rows, cols];
//     for (int i = 0; i < rows; i++)
//         for (int j = 0; j < cols; j++)
//             array[i, j] = new Random().Next(min, max + 1);
//     return array;
// }

// void Show2dArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
// }

// int[,] ChangeArrayRows(int[,] array)
// {
// for (int i = 0; i < array.GetLength(0); i++)
// {
//     for (int j = 0; j < array.GetLength(1) - 1; j++)
//     {
//         for (int z = 0; z < array.GetLength(1) - 1; z++)
//         {
//             if (array[i, z] < array[i, z + 1])
//             {
//                 int temp = 0;
//                 temp = array[i, z];
//                 array[i, z] = array[i, z + 1];
//                 array[i, z + 1] = temp;
//             }
//         }
//     }
// }
// return array;
// }


// int rows = 4;
// int cols = 4;
// int min =1;
// int max = 10;
// Console.WriteLine();
// int [,] array = CreateRandom2dArray(rows,cols,min,max);
// Show2dArray(array);
// Console.WriteLine();
// Console.WriteLine("Массив с упорядоченными значениями: ");
// Console.WriteLine();
// int [,] changeArray = ChangeArrayRows(array);
// Show2dArray(changeArray);
// Console.WriteLine();






// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка





// int[,] CreateRandom2dArray(int rows, int cols, int min, int max)
// {
//     int[,] array = new int[rows, cols];
//     for (int i = 0; i < rows; i++)
//         for (int j = 0; j < cols; j++)
//             array[i, j] = new Random().Next(min, max + 1);
//     return array;
// }

// void Show2dArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
// }

// int[,] ChangeArrayRows(int[,] array)
// {
// int index = 0;
// int minsum = Int32.MaxValue;;

// for (int i = 0; i < array.GetLength(0); i++)
// {
//     int sum = 0;
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         sum = sum + array[i, j];    
//     }
//     if (sum < minsum)
//     {      
//         minsum = sum;
//         index++;
//     }
// }
// Console.WriteLine($"номер строки с наименьшей суммой элементов:  {index}, с суммой елементов равной:  {minsum}");
//     return array;
// }



// int rows = 4;
// int cols = 4;
// int min =1;
// int max = 10;
// Console.WriteLine();
// int [,] array = CreateRandom2dArray(rows,cols,min,max);
// Show2dArray(array);
// ChangeArrayRows(array);


// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18