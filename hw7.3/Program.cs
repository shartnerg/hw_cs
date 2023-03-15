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

void FindAVG(int[,] matrix)
{
    int rows = matrix.GetLength(0);
    int cols = matrix.GetLength(1);
    double[] avg = new double[cols];
    for (int j = 0; j < cols; j++)
    {
        int sum = 0;
        for (int i = 0; i < rows; i++)
        {
            sum += matrix[i, j];
        }
        avg[j] = (double)sum / rows;
    }

    Console.WriteLine("Srednee arifmeticheskoe v kazhdom stolbce:");
    for (int j = 0; j < cols; j++)
    {
        Console.WriteLine("Stolbec {0}: {1}", j, avg[j]);
    }
}

Console.Clear();
Console.Write("Vvedite razmer massiva: ");
int[] size = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];
InputMatrix(matrix);
PrintMatrix(matrix);
FindAVG(matrix);
