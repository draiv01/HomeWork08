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
//             Console.Write(array[i, j] + " | ");
//         }
//         Console.WriteLine();
//     }
// }

// int[,] ChangeArrayRows(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             for (int z = 0; z < array.GetLength(1); z++)
//             {
//                 array[i, j] = array[i, j] + (array[i, z] * array[z, j]);
//             }
//         }
//     }
//     return array;
// }


// int rows = 2;
// int cols = 2;
// int min = 1;
// int max = 5;
// Console.WriteLine();
// int[,] array = CreateRandom2dArray(rows, cols, min, max);
// Show2dArray(array);
// Console.WriteLine();
// Console.WriteLine("Результирующая матрица будет: ");
// Console.WriteLine();
// int[,] changeArray = ChangeArrayRows(array);
// Show2dArray(changeArray);
// Console.WriteLine();

// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

// int deep1 = InputInt("Введите размерность 1: ");
// int deep2 = InputInt("Введите размерность 2: ");
// int deep3 = InputInt("Введите размерность 3: ");
// int countNums = 99;

// if (deep1 * deep2 * deep3 > countNums)
// {
//     Console.Write("Массив слишком большой");
//     return;
// }

// int[,,] resultNums = Create3DMassive(deep1, deep2, deep3);

// for (int i = 0; i < resultNums.GetLength(0); i++)
// {
//     for (int j = 0; j < resultNums.GetLength(1); j++)
//     {
//         for (int k = 0; k < resultNums.GetLength(2); k++)
//         {
//             Console.WriteLine($"[{i},{j},{k}] - {resultNums[i, j, k]}");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }


// int[,,] Create3DMassive(int size1, int size2, int size3)
// {
//     int[,,] array = new int[size1, size2, size3];
//     int[] values = new int[countNums];
//     int num= 10;
//     for (int i = 0; i < values.Length; i++)
//         values[i] = num
//         ++;

//     for (int i = 0; i < values.Length; i++)
//     {
//         int randomInd = new Random().Next(0, values.Length);
//         int temp = values[i];
//         values[i] = values[randomInd];
//         values[randomInd] = temp;
//     }

//     int valueIndex = 0;

//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             for (int k = 0; k < array.GetLength(2); k++)
//             {
//                 array[i, j, k] = values[valueIndex++];
//             }
//         }
//     }
//     return array;
// }


// int InputInt(string output)
// {
//     Console.Write(output);
//     return int.Parse(Console.ReadLine());
// }

// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

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
// int temp = 1;
// int i = 0;
// int j = 0;
// {
// while (temp <= array.GetLength(0) * array.GetLength(1))
// {
//   array[i, j] = temp;
//   temp++;
//   if (i <= j + 1 && i + j < array.GetLength(1) - 1)
//   {
//     j++;
//   }
//   else if (i < j && i + j >= array.GetLength(0) - 1)
//   {
//     i++;
//   }
//   else if (i >= j && i + j > array.GetLength(1) - 1)
//   {
//     j--;
//   }
//   else
//   {
//     i--;
//   }
// }
// return array;
// }



// int rows = 4;
// int cols = 4;
// int min =1;
// int max = 9;
// int [,] array = CreateRandom2dArray(rows,cols,min,max);
// Show2dArray(array);
// int [,] changeArray = ChangeArrayRows(array);
// Show2dArray(changeArray);