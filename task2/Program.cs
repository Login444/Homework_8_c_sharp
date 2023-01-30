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

void SumOfRow(int [,] matr)
{
    int sum = 0;
    int maxSum =0;
    int i =0;
    for (int rows = 0; rows < matr.GetLength(0); rows++)
    {
        for (int columns = 0; columns < matr.GetLength(1); columns++)
        {
            sum = sum  + matr[rows,columns];
        }
    maxSum[i] = sum;
    i++;
    }
    if (maxSum[i]>maxSum[i+1])
    {
        Console.WriteLine($"Максимальная сумма у строки номер {i+1}");
    }
}

int[,] arr = new int [3,4];

FillArray(arr);
PrintArray(arr);
SumOfRow(arr); 