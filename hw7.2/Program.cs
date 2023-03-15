void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            matrix[i, j] = new Random().Next(1, 11);
    }
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            Console.Write($"{matrix[i, j]} \t");
        Console.WriteLine();
    }
}



void Findelement(int[,] matrix)
{
    Console.Write("Vvedite nomer stroki: ");
    int row = Convert.ToInt32(Console.ReadLine());
    Console.Write("Vvedite nomer stolbca: ");
    int col = Convert.ToInt32(Console.ReadLine());

    if (row < 0 || row >= matrix.GetLength(0) || col < 0 || col >= matrix.GetLength(1))
    {
        Console.WriteLine("Takogo elementa v massive net");
    }
    else
    {
        int element = matrix[row, col];
        Console.WriteLine("element: " + element);
    }
}



Console.Clear();
Console.Write("Vvedite razmer massiva: ");
int[] size = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];
InputMatrix(matrix);
PrintMatrix(matrix);
Findelement(matrix);
