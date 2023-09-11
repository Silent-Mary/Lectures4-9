// string[,] table = new string[2, 5];

// String.Empty
// table[0, 0]  table[0, 1]  table[0, 2]  table[0, 3]  table[0, 4]  
// table[1, 0]  table[1, 1]  table[1, 2]  table[1, 3]  table[1, 4]  

/* table[1, 2] = "word";

for (int rows = 0; rows < 2; rows++)
{
    for (int columns = 0; columns < 5; columns++)
    {
        System.Console.WriteLine($"-{table[rows, columns]}-");
    }    
} */

void PrintMatrix(int[,] matrX)
{
    for (int i = 0; i < matrX.GetLength(0); i++)
    {
         for (int j = 0; j < matrX.GetLength(1); j++)
         {
            System.Console.Write($"{matrX[i, j]} ");  
         } 
    Console.WriteLine();
    }
}

void FillMatrix(int[,] matrX)
{
    for (int i = 0; i < matrX.GetLength(0); i++)
    {
        for (int j = 0; j < matrX.GetLength(1); j++)
        {
            matrX[i, j] = new Random().Next(1, 10); // [1; 10)
        }
    }
}

int[,] matrix = new int[3, 4];
PrintMatrix(matrix);
Console.WriteLine();
FillMatrix(matrix);
PrintMatrix(matrix);