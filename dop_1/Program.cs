// Даны две матрицы, количество строк и столбцов которых может быть 3 или 4, заполнены числами от -9 до 9. Выполните умножение матриц.

Random random = new Random();
int rows = random.Next(3, 5);
int cols = random.Next(3, 5);
int[,] matrixA = new int[rows, cols];
int[,] matrixB = new int[rows, cols];

FillArray(matrixA);
FillArray(matrixB);
PrintMatrix(matrixA);
Console.WriteLine();
PrintMatrix(matrixB);
Console.WriteLine();
if (matrixA.GetLength(1) == matrixB.GetLength(0)) PrintMatrix(MatrixMultiplication(matrixA, matrixB));
else Console.WriteLine("Умножение матриц невозможно.");


void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            if (matrix[i, j] >= 10) Console.Write(matrix[i, j] + "   ");
            else Console.Write(matrix[i, j] + "    ");
        }
        Console.WriteLine();
    }
}

void FillArray(int[,] matrix)
{
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            matrix[i, j] = random.Next(-9, 10);
        }
    }
}

int[,] MatrixMultiplication(int[,] matrix1, int[,] matrix2)
{
    // Если матрица  A  содержит  m  строк, а матрица  B  содержит  n-столбцов, то произведение  AB  представляет собой матрицу  С  размера  m × n. Элемент , стоящий в  i-ой строке и  j-ом столбце матрицы  AB, вычисляется по правилу умножения строки на столбец:  i-ая строка матрицы  A  умножается на  j-ый столбец матрицы  B.

    int[,] resultMatrix = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix2.GetLength(1); j++)
        {
            for (int k = 0; k < matrix2.GetLength(0); k++)
            {
                resultMatrix[i, j] += matrix1[i, k] * matrix2[k, j];
            }
        }
    }
    return resultMatrix;
}
