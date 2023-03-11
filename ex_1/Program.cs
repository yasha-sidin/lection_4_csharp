// двумерные массивы

void PrinrTwoArray(int[,] matrix)
{
    for (int rows = 0; rows < matrix.GetLength(0); rows++)
    {
        for (int columns = 0; columns < matrix.GetLength(1); columns++)
        {
            Console.Write($"{matrix[rows, columns]} ");
        }
        Console.WriteLine();
    }
}

int[,] GetFillTwoIntArray(int rows, int columns, int startRange, int endRange)
{
    int[,] matrix = new int[rows, columns];
    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
        {
            matrix[i, j] = new Random().Next(startRange, endRange + 1);
        }
    }

    return matrix;
}

int[,] matrix = GetFillTwoIntArray(10, 10, 0, 1);
PrinrTwoArray(matrix);

