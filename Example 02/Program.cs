Console.Clear();

int[,] pic = new int[,]
{
    {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,},
    {0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0, 0,},
    {0, 0, 0, 0, 0, 0, 1, 0, 0, 1, 0, 0, 0, 0, 0, 0,},
    {0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0,},
    {0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0,},
    {0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0,},
    {0, 0, 1, 0, 0, 0, 1, 1, 1, 0, 0, 0, 0, 1, 0, 0,},
    {0, 1, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 1, 0,},
    {0, 1, 0, 0, 1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0,},
    {0, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 0, 0,},
};

void PrintImage(int[,] image)
{
    for (int i = 0; i < image.GetLength(0); i++)
    {
         for (int j = 0; j < image.GetLength(1); j++)
         {
            if(image[i, j] == 0) System.Console.Write(" ");
            else System.Console.Write("+");  
         } 
    Console.WriteLine();
    }
}

// recursion; function calls itself
void ColorImage(int row, int col)
{
    if(pic[row, col] == 0)
    {
        pic[row, col] = 1;
        ColorImage(row-1, col);
        ColorImage(row, col-1);
        ColorImage(row+1, col);
        ColorImage(row, col+1);
    }
}

PrintImage(pic);
ColorImage(5, 5);
PrintImage(pic);