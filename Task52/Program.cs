/* Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое 
элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/

int[,] GetArray(int row, int col, int minValue, int maxValue)
{
    int[,] result = new int[row, col];

    for (int i = 0; i < row; i++)
        for (int j = 0; j < col; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    return result;
}

int[] SummaColumns(int[,] arrayOld)
{
    int[] sum = new int[arrayOld.GetLength(1)];

    for (int i = 0; i < arrayOld.GetLength(0); i++)
    {
        for (int j = 0; j < arrayOld.GetLength(1); j++)
        {
            sum[j] += arrayOld[i, j];
        }
    }
    return sum;
}

void PrintArray(int[,] array)
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

int[,] myArray = GetArray(m, n, 0, 10);
PrintArray(myArray);
Console.WriteLine();
int[] resultSum = SummaColumns(myArray);
//Console.WriteLine($"Сумма по столбцам: {String.Join("; ", resultSum)}");
//Console.WriteLine();
foreach (double average in resultSum)
{
    Console.Write($"{average / 3:f2} ");
}