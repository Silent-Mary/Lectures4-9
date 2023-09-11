// 2D array; find sum of elements on main diagonal; indexes (0, 0), (1, 1), etc... */ 

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

Console.WriteLine("Enter N of rows, N of columns, min N & max N for range: ");
int rows = Convert.ToInt32(Console.ReadLine());
int columns = Convert.ToInt32(Console.ReadLine());
int min = Convert.ToInt32(Console.ReadLine());
int max = Convert.ToInt32(Console.ReadLine());

int[,] userMatrix = GetRandomMatrix(rows, columns, min, max);
Console.Clear();
Console.ForegroundColor = ConsoleColor.Green;
PrintMatrix(userMatrix);

int SumMainDiagonal(int[,] array)
{
    int sum = 0;
    int columns = array.GetLength(0);
    int rows = array.GetLength(1);
    int size = columns;
    if (columns > rows) size = rows;

    for (int i = 0; i < size; i++)
    {
        sum += array[i, i];
    }
    return sum;
}

Console.WriteLine();
Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine($"Sum of main diagonal elements = {SumMainDiagonal(userMatrix)}"); 
Console.ForegroundColor = ConsoleColor.White; 