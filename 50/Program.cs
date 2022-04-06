// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

int rows = 10;
int cols = 10;
int[,] array = new int[rows, cols];

FillArray();
Console.WriteLine("Дан массив: ");
PrintArray();
Console.WriteLine();

Console.Write("Введите номер строки элемента: ");
int rowElement = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите номер столбца элемента: ");
int columnElement = Convert.ToInt32(Console.ReadLine());
if (rowElement > rows | columnElement > cols) Console.WriteLine("Такого элемента нет.");
else Console.WriteLine($"Элемент находящийся на {rowElement} строке {columnElement} столбце: {array[rowElement, columnElement]}");

void FillArray()
{
    Random random = new Random();
    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < cols; j++)
        {
            array[i, j] = random.Next(1, 11);
        }
    }
}

void PrintArray()
{
    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < cols; j++)
        {
            if (array[i, j] >= 10) Console.Write(array[i, j] + "   ");
            else Console.Write(array[i, j] + "    ");
        }
        Console.WriteLine();
    }
}