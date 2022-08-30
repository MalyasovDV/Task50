void ArrayGeneration(ref int[,] array)
{
    Random rnd = new Random();
    for(int i = 0; i < array.GetLength(0); ++i)
        for (int j = 0; j < array.GetLength(1); ++j)
            array[i,j] = rnd.Next(-10,10);
}

void ArrayOutput(int[,] array)
{
    Console.WriteLine("\n Массив:");
    for(int i = 0; i < array.GetLength(0); ++i)
        {
            for (int j = 0; j < array.GetLength(1); ++j)
                Console.Write(array[i,j] + " ");
            Console.WriteLine();
        }
}

void CheckPosition(int index1, int index2, ref int[,] array)
{
    try
    {
        Console.WriteLine("Элемент на позиции [{0};{1}]: {2}", index1, index2, array[index1,index2]);
    }
    catch
    {
        Console.WriteLine("Элемента на позиции [{0};{1}] не существует", index1, index2);
    }
}

Console.WriteLine("Введите размерность массива(строки, столбцы)");

int m = int.Parse(Console.ReadLine());
int n = int.Parse(Console.ReadLine());
int[,] array= new int[m,n];

ArrayGeneration(ref array);
ArrayOutput(array);

Console.WriteLine("\n Введите позицию элемента в массиве");

m = int.Parse(Console.ReadLine());
n = int.Parse(Console.ReadLine());

CheckPosition(m,n,ref array);