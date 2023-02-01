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
int[,] GetMultMatr(int[,] arrayA, int[,] arrayB)
{
    int[,] arrayC = new int[arrayA.GetLength(0), arrayB.GetLength(1)];
    for (int i = 0; i<arrayA.GetLength(0); i++)
    {
        for (int j=0; j<arrayB.GetLength(1); j++)
        {
            for (int k = 0; k<arrayA.GetLength(1); k++)
            {
                arrayC[i,j] += arrayA[i,k] * arrayB[k,j];
            }
        }
    }
    return arrayC;
}

// void MatrPow(int[,] firstMatr, int[,] secondMatr)
// {
//     int[,] resultMatr = new int[firstMatr.GetLength(0), secondMatr.GetLength(1)];
//     for (int rows = 0; rows < firstMatr.GetLength(0); rows++)
//     {
//         for (int columns = 0; columns < secondMatr.GetLength(1); columns++)
//         {
//             for (int k = 0; k < firstMatr.GetLength(1); k++)
//             {
//                 resultMatr[rows, columns] += firstMatr[rows, k] * secondMatr[k, columns];
//                 Console.Write($"{resultMatr[rows,columns]} ");
//             }
//         }
//         Console.WriteLine();
//     }
// }

int[,] arr1 = new int[3, 4];
int[,] arr2 = new int[3, 4];

FillArray(arr1);
FillArray(arr2);
PrintArray(arr1);
PrintArray(arr2);

PrintArray(GetMultMatr(arr1,arr2));
