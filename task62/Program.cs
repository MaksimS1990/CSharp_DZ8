// Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

Console.WriteLine("Программа заполняет массив спирально!");

Console.WriteLine("введите количество строк");
int n = int.Parse(Console.ReadLine()!);

int[,] array = FillTheSpiral(n);

PrintArray(array);

int[,] FillTheSpiral(int n)                                    // функция заполняет массив по принципу спирали
{
    int[,] array = new int[n, n];
    int start = 1;
    for (int i = 1; i <= n / 2; i++)
    {
        for (int j = i - 1; j < n - i + 1; j++)
        {
            array[i - 1, j] = start++;
        }
        for (int j = i; j < n - i + 1; j++)
        {
            array[j, n - i] = start++;
        }
        for (int j = n - i - 1; j >= i - 1; j--)
        {
            array[n - i, j] = start++;
        }
        for (int j = n - i - 1; j >= i; j--)
        {
            array[j, i - 1] = start++;
        }
    }
    if (n % 2 == 1) array[n / 2, n / 2] = n * n;
    return array;
}

void PrintArray(int[,] array)                                   // функция выводит массив в консоль
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(String.Format("{0,4}", array[i, j]));
        }
        Console.WriteLine();
    }
}
