// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9


Console.WriteLine("Первую размерность массива");
int rows = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Вторая размерность массива");
int colomns = Convert.ToInt32(Console.ReadLine());

double[,] matrix = new double[rows, colomns];

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i, j] = new Random().Next(-10, 10) + new Random().NextDouble();
        matrix[i, j] = Math.Round(matrix[i, j] * 100.0) / 100.0;
        Console.Write(matrix[i, j] + " ");
    }
    Console.WriteLine();
}

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

Console.WriteLine("Введите номер ряда");
int numRows = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите номер столбца");
int numColomns = Convert.ToInt32(Console.ReadLine());

int[,] matrix = new int[7, 7];

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i, j] = i + j;
        Console.Write(matrix[i, j] + " ");

        if (numRows == matrix.GetLength(0)[0])
        {
            matrix.GetLength(0)[0] = matrix.GetLength(0)[0] + 1;
        }

        Console.WriteLine("Ваше число присутствует в ряду");


        if (numColomns == matrix.GetLength(1)[0])
        {
            matrix.GetLength(1)[0] = matrix.GetLength(1)[0] + 1;
        }
    }
    Console.WriteLine("Ваше число присутствует в столбце");
}
System.Console.WriteLine("Ваше число " + );

// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] matrix = new int[4, 4];
int result = 0, sum = 0;
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i, j] = i + j;
        Console.Write(matrix[i, j] + " ");
    }
    Console.WriteLine();
}
for (int j = 0; j < matrix.GetLength(1); j++)
{
    sum = sum + matrix.GetLength(1);
}

result = sum / matrix.GetLength(1);

Console.WriteLine("Cреднее арифметическое чисел = " + result);
Console.ReadKey();