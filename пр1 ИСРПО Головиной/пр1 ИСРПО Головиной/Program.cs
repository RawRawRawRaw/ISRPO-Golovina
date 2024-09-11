using System.Numerics;

Console.Write("Введите размер квадратной матрицы: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[n,n];
Console.WriteLine("Введите элементы матрицы по строкам:");
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        Console.Write($"элемент [{i+1},{j+1}]: ");
        matrix[i,j] = int.Parse(Console.ReadLine());
    }
}
bool Sim = Sim1(matrix, n);
bool Sim1(int[,] matrix, int n){
    
    for(int i = 0; i < n; i++)
    {
        for(int j = 0; j < n; j++)
        {
            if(matrix[i, j] != matrix[j, i])
            {
                return false;
            }
        }
    }
    return true;
}

Console.WriteLine($"матрица симметрична? Ответ: {Sim}");