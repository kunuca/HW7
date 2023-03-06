// Написать программу, упорядочивания по убыванию элементы каждой строки двумерной массива.
void PrintIn(string message)
{
    Console.WriteLine(message);
}

void FillMatrix(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
        {for (int j = 0; j < arr.GetLength(1); j++)
            {
                arr[i,j]=new Random().Next(0,10);
            }
        
    }
}

void PrintMatrix(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {for (int j = 0; j < arr.GetLength(1); j++)
    {
        Console.Write($"\t {arr[i,j]}");
    }
        Console.WriteLine();
    }
}


PrintIn("Введите ширину матрицы");
int lenght=int.Parse(Console.ReadLine()!);
PrintIn("Введите высоту матрицы");
int hight=int.Parse(Console.ReadLine()!);
int[,] matrix=new int[hight,lenght];
FillMatrix(matrix);
PrintMatrix(matrix);
Console.WriteLine();
for (int i = 0; i < hight; i++)
 { for (int j = 0; j < lenght; j++)
    { int minPosition=j;
         for (int k = j+1; k < lenght; k++)
        {
            if(matrix[i,k]<matrix[i,minPosition]) minPosition=k;
        }
    int temp=matrix[i,j];
    matrix[i,j]=matrix[i,minPosition];
    matrix[i,minPosition]=temp;
}
    
}
PrintMatrix(matrix);