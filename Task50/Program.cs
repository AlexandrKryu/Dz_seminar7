// Задача 50. Напишите программу, которая на вход принимает позиции элемента
//  в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого элемента в массиве нет

Console.WriteLine("Введите координаты элемента по строке:");
int elemRow = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координаты элемента по столбцу: ");
int elemCol = int.Parse(Console.ReadLine()!);


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

void PrintMatrixElem(int[,] matrix)
{
if (elemRow < 1 || elemRow > matrix.GetLength(0) || elemCol < 1 || elemCol > matrix.GetLength(1))
{
  Console.Write("Элемента нет");
}
else
{
  Console.Write($"Элемент = {matrix[elemRow-1, elemCol-1]}");
}   
}
int[,] matrix = CreateMtrixRndInt(3, 5, 2, 20);
PrintMatrix(matrix);
PrintMatrixElem(matrix);