// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] CreateMtrixRndInt(int row, int col, int min, int max)
{
    int[,] matrix = new int[row, col];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max);
        }
    }
    return matrix;
}
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) System.Console.Write($"{matrix[i, j],4},");
            else Console.Write($"{matrix[i, j],4} ");
        }
        Console.WriteLine("]");
    }
}

void MeanElemCol(int[,] array)
{
    int col = array.GetLength(1);
    // int[] result = new int[col];
    // double[] res = new double[result.Length];
    for (int j = 0; j < array.GetLength(1); j++)
    {
        double mean = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            mean += array[i, j];
        }
        Console.Write($"{Math.Round((mean / array.GetLength(0)), 3),4}  ");
    }
}


int[,] matrix = CreateMtrixRndInt(4, 4, 20, 100);
PrintMatrix(matrix);
MeanElemCol(matrix);

