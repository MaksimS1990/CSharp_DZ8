// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

Console.WriteLine("Программа задаёт двумерный массив и упорядочевает по убыванию элементы каждой строки двумерного массива!");

Console.WriteLine("введите количество строк");
int rows = int.Parse(Console.ReadLine()!);
Console.WriteLine("введите количество столбцов");
int columns = int.Parse(Console.ReadLine()!);
Console.WriteLine();

CreateArray(rows, columns);
WriteArray(array);

Console.WriteLine($"Отсортированный массив: ");
SortingStringsInAnArray(array);
WriteArray(array);

int[,] CreateArray(int rows, int columns)                               // функция создаёт массов
{
    Random random = new Random();

    for (var i = 0; i < array.GetLength(0); i++)
    {
        for (var j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 11);
        }
    }

    return array;
}

void SortingStringsInAnArray(int[,] array)                              // функция сортирует массив по убыванию в каждой строке
{
    int[,] array = new int[rows, columns];

    for (var i = 0; i < array.GetLength(0); i++)
    {
        for (var j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1) - 1; k++)
            {
                if (array[i, k] < array[i, k + 1])
                {
                    int temp = array[i, k + 1];
                    array[i, k + 1] = array[i, k];
                    array[i, k] = temp;
                }
            }
        }
    }
}

void WriteArray(int[,] array)                                            // функция выводит массив
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}
