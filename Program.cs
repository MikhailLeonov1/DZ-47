//Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.


internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Количество строк:");
        int m = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Количество стобцов:");
        int n = Convert.ToInt32(Console.ReadLine());

        double[,] x = new double[m, n];
        Random rnd = new Random();
        void PrintArray(double[,] matr)
        {
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                { Console.Write($"{matr[i, j]} "); }
                Console.WriteLine();
            }
        }
        void FillArray(double[,] matr)
        {
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                { matr[i, j] = Convert.ToDouble(rnd.Next(-100, 100) / 10.0); }
            }
        }
        FillArray(x);
        Console.WriteLine();
        PrintArray(x);
    }
}