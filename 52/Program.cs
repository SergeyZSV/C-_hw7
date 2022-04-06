// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

int rows = 4;
int cols = 4;
int[,] array = new int[rows, cols];

Console.WriteLine();
FillArray();
Console.WriteLine("Дан массив: ");
PrintArray();
Console.WriteLine();

for (int i = 0; i < cols; i++)
{
    Console.WriteLine($"Среднее арифметическое в столбце {i + 1} равно {AverageOfColumn(i)}.");
}
Console.WriteLine();

void FillArray()
{
    Random random = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            array[i, j] = random.Next(1, 11);
        }
    }
}

void PrintArray()
{
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            if (array[i, j] >= 10) Console.Write(array[i, j] + "   ");
            else Console.Write(array[i, j] + "    ");
        }
        Console.WriteLine();
    }
}

double AverageOfColumn(int column)
{
    double sum = 0;
    double average = 1;
    for (int i = 0; i < rows; i++)
    {
        sum += array[i, column];
    }
    average = sum / rows;
    return average;
}