// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

int m = 4;
int n = 4;
double[,] array = new double[m, n];

FillArray();
Console.WriteLine("Дан массив: ");
PrintArray();

void FillArray()
{
    Random random = new Random();
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = Convert.ToDouble(random.Next(-1000, 1001)) / 10;
        }
    }
}

void PrintArray()
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Console.Write(array[i, j] + "       ");
        }
        Console.WriteLine();
    }
}