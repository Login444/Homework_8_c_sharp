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
    int i = 0;
    int minIndex =0;
    int maxIndex=0;
    int min = 0;
    int max = 0;
    int [] mas = new int[matr.GetLength(0)];
    for (int rows = 0; rows < matr.GetLength(0); rows++)
    {
        for (int columns = 0; columns < matr.GetLength(1); columns++)
        {
            sum = sum  + matr[rows,columns];
        }
    mas[i] = sum;
    sum = 0;
    i++;
    }
    for (int j = 0; j<mas.Length; j++)
    {
        if (max < mas[j])
        {
            max = mas[j];
            maxIndex = j;
        }
        else
        {
            min = mas[j];
            minIndex = j;
        }
    }
    Console.WriteLine($"Строка номер {minIndex+1} содержит наименьшую сумму");
}

int[,] arr = new int [2,3];

FillArray(arr);
PrintArray(arr);
SumOfRow(arr); 