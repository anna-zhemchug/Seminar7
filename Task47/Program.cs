/* Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/
double[,] GetArray(int row, int col, int minValue, int maxValue)
{
    double[,] result = new double[row, col];

    for (int i = 0; i < row; i++)
        for (int j = 0; j < col; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    return result;
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i, j]} ");
        Console.WriteLine();
    }
}

Console.Write("m = ");
int m = int.Parse(Console.ReadLine());
Console.Write("n = ");
int n = int.Parse(Console.ReadLine());

double[,] myArray = GetArray(m, n, -10, 10);
PrintArray(myArray);