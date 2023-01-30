void PrintArray(int[,] matr)
{
    Console.WriteLine();
    for (int rows = 0; rows < matr.GetLength(0); rows++)
    {
        for (int columns = 0; columns < matr.GetLength(1); columns++)
        {
            Console.Write($"{matr[rows, columns]} ");
        }
        Console.WriteLine();
    }
}

void FillArray(int[,] matr)
{
    for (int rows = 0; rows < matr.GetLength(0); rows++)
    {
        for (int columns = 0; columns < matr.GetLength(1); columns++)
        {
            matr[rows, columns] = new Random().Next(1, 10);
        }
        Console.WriteLine();
    }
}

void SortArray(int [,] matr)
{
    int max = 0;
    for (int rows = 0; rows < matr.GetLength(0); rows++)
    {
        for (int columns = 0; columns < matr.GetLength(1); columns++)
        {
            for (int j = columns +1; j < matr.GetLength(1); j++)
            if (matr[rows,j] > matr[rows,columns])
            {
                max = matr[rows,j];
                matr[rows,j] = matr[rows,columns];
                matr[rows,columns] = max;
            }
        }
    }
}

int[,] arr = new int [4,4];

FillArray(arr);
PrintArray(arr);
SortArray(arr);
PrintArray(arr);