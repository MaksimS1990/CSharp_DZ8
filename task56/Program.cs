// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

Console.WriteLine("Программа задаёт прямоугольный массив и находит строку с наименьшей суммой элементов!");

uint rows;
uint columns;
RowsSum();
ColumnsSum();

int[,] array = CreateArray(rows, columns);
Console.WriteLine("Сгенерированный массив ");
PrintArray(array);
SumLineElements(array);

void RowsSum()                                                                         // Функция считывания количества строк из консоли
{
    Console.WriteLine("Введите количество строк ");
    while (!uint.TryParse(Console.ReadLine()!, out rows) || (rows == 0))
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Неверный ввод");
        Console.ResetColor();
        Console.WriteLine("Введите количество строк ");
    }
}

void ColumnsSum()                                                                     // Функция считывания количества столбцов из консоли
{
    Console.WriteLine("Введите количество столбцов ");
    while (!uint.TryParse(Console.ReadLine()!, out columns) || (columns == 0))
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Неверный ввод");
        Console.ResetColor();
        Console.WriteLine("Введите количество столбцов ");
    }
}

int[,] CreateArray(uint rows, uint columns)                                           // Функция заполнения массива случайными числами
{
    int[,] array = new int[rows, columns];
    Random random = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.Next(1, 10);
        }
    }
    return array;
}

void PrintArray(int[,] array)                                                         // Функция вывода массива в консоль
{
    Console.WriteLine();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(String.Format("{0,4}", array[i, j]));
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void SumLineElements(int[,] array)                                                    // функция находит наименьшую сумму элементов строки
{
    int index = 0;
    int sumLine = int.MaxValue;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        int temp = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            temp += array[i, j];
        }
        if (temp < sumLine)
        {
            sumLine = temp;
            index = i;
        }
    }
    Console.WriteLine("Строка " + (index + 1) + " Сумма элементов строки " + sumLine);
}