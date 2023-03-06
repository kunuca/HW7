// В прямоугольной матрице найти строку с наименьшей суммой элементов.
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
int positionMin=0;
int minSum=0;
for (int i = 0; i < lenght; i++)
{
    minSum=minSum+matrix[0,i];
}
for (int i = 0; i < hight; i++)
{ int sum=0;
    for (int j = 0; j < lenght; j++)
    {
        sum=sum+matrix[i,j];
        
    }
    PrintIn($"{sum}");
    if (minSum>sum)
    {minSum=sum;
    positionMin=i;}
}
PrintIn($"Наименьшая сумма элементов находится в {positionMin+1} строке");