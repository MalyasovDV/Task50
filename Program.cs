void MatrixGeneration(ref int[,] matrix)
{
    Random rnd = new Random();
    for(int i = 0; i < matrix.GetLength(0); ++i)
        for (int j = 0; j < matrix.GetLength(1); ++j)
            matrix[i,j] = rnd.Next(-10,10);
}

void MatrixOutput(int[,] matrix)
{
    Console.WriteLine("\n Массив:");
    for(int i = 0; i < matrix.GetLength(0); ++i)
        {
            for (int j = 0; j < matrix.GetLength(1); ++j)
                Console.Write(matrix[i,j] + " ");
            Console.WriteLine();
        }
}

void CheckPosition(int index1, int index2, ref int[,] matrix)
{
    try
    {
        Console.WriteLine("\nЭлемент на позиции [{0};{1}]: {2}", index1, index2, matrix[index1,index2]);
    }
    catch
    {
        Console.WriteLine("\nЭлемента на позиции [{0};{1}] не существует", index1, index2);
    }
}

Console.WriteLine("Введите размерность массива(строки, столбцы)");

int m = int.Parse(Console.ReadLine());
int n = int.Parse(Console.ReadLine());
int[,] matrix= new int[m,n];

MatrixGeneration(ref matrix);
MatrixOutput(matrix);

Console.WriteLine("\n Введите позицию элемента в массиве");

m = int.Parse(Console.ReadLine());
n = int.Parse(Console.ReadLine());

CheckPosition(m,n,ref matrix);