/* Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
m = 1, n =7 -> такого числа в массиве нет
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

bool FindArray(int[,] arrayOld, int numRow, int numCol)
{
    for (int i = 0; i < arrayOld.GetLength(0); i++)
    {
        for (int j = 0; j < arrayOld.GetLength(1); j++)
        {
            if (i == numRow && j == numCol)
            {
                return true;
            }
        }
    }
    return false;
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

Console.Write("Введите номер строки: ");
int numRow = int.Parse(Console.ReadLine());
Console.Write("Введите номер столбца: ");
int numCol = int.Parse(Console.ReadLine());

if (FindArray(myArray, numRow, numCol))
{
    Console.WriteLine($"{myArray[numRow, numCol]}");
}
else Console.WriteLine("Такого числа в массиве нет");