/* Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3. */

//                        строки     столбцы
int[,] GetRandomMatrix(int rows, int columns, int leftRange, int rightRange)
{
    int[,] matrix = new int[rows,columns];

    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(leftRange, rightRange + 1);
        }
    }

    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}

//Среднее арифметическое элементов каждого столбца:
void AverageColumn(int[,] matrix)
{
    for(int j = 0; j < matrix.GetLength(1); j++)
    {
        double result = 0;
        for(int i = 0; i < matrix.GetLength(0); i++)
        {
            result += matrix[i, j];
            //Console.Write($"{matrix[i, j]}; ");
        }
        double res = result / matrix.GetLength(0);
        Console.WriteLine();
        Console.Write($"Среднее арифметическое каждого столбца: {res:f1}");
    }
}

const int ROWS = 5;
const int COLUMNS = 7;
const int LEFTRANGE = 0;
const int RIGHTRANGE = 9;

int[,] array = GetRandomMatrix(ROWS, COLUMNS, LEFTRANGE, RIGHTRANGE);
PrintMatrix(array);
AverageColumn(array);