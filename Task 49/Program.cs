// 2D array where even-index numbers get squared 

Console.Clear();

int[,] GetRandomMatrix(int row, int column, int start, int end)
{
    int[,] matrix = new int[row, column];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            matrix[i, j] = new Random().Next(start, end+1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrixToPrint)
{
    System.Console.Write($"[ ]\t");
    for (int i = 0; i < matrixToPrint.GetLength(1); i++)
    {
        Console.Write($"[{i}]\t");
    }
    Console.WriteLine();

    for (int i = 0; i < matrixToPrint.GetLength(0); i++)
    {
        Console.Write($"[{i}]\t");
         for (int j = 0; j < matrixToPrint.GetLength(1); j++)
         {
            System.Console.Write(matrixToPrint[i, j] +"\t");  
         } 
    Console.WriteLine();
    }
}

int [,] SquareEven(int[,] matrixToSquare)
{
    int[,] result = new int[matrixToSquare.GetLength(0), matrixToSquare.GetLength(1)];
    for (int i = 0; i < matrixToSquare.GetLength(0); i++)
    {
        for (int j = 0; j < matrixToSquare.GetLength(1); j++)
        {
           if (i%2 == 0 && j%2 == 0) result[i, j] = matrixToSquare[i, j] * matrixToSquare[i, j];
           else result[i, j] = matrixToSquare[i, j];
        }
    }
    return result;
}

Console.WriteLine("Enter N of rows, N of columns, min N & max N for range: ");
int rows = Convert.ToInt32(Console.ReadLine());
int columns = Convert.ToInt32(Console.ReadLine());
int min = Convert.ToInt32(Console.ReadLine());
int max = Convert.ToInt32(Console.ReadLine());

int[,] userMatrix = GetRandomMatrix(rows, columns, min, max);
Console.Clear();
Console.ForegroundColor = ConsoleColor.Green;
PrintMatrix(userMatrix);
Console.WriteLine();
Console.ForegroundColor = ConsoleColor.Blue;
int[,] squaredMatrix = SquareEven(userMatrix);
PrintMatrix(squaredMatrix);
Console.ForegroundColor = ConsoleColor.White;