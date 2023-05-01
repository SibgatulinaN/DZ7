/* Задача 47. Задайте двумерный массив размером m×n,
 заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9 */
/* double[,] twoDimArray = new double[m, n];
Random rnd = new Random();
int[,] Creatarray(int length1, int length2)
{
int[,] Array = new int [length1, length2];
for (int i = 0; i < Array.GetLength(0); i++)
{
    for (int j = 0; j < Array.GetLength(1); j++)
    {
        //Array[i,j] = new Random(Math.Round.Next)();
        Array[i,j] = Convert.ToDouble(rnd.Next());
    }
}
return Array;

}

void PrintArray (int [,] Array)
{
for (int i = 0; i < Array.GetLength(0); i++)
{
    for (int j = 0; j < Array.GetLength(1); j++)
    {
        System.Console.Write($"{Array [i,j]}  ");

    }
    System.Console.WriteLine();
}

}
PrintArray(Creatarray(4,4)); */

Console.WriteLine("Задайте количество строк двумерного массива:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте количество столбцов двумерного массива:");
int n = Convert.ToInt32(Console.ReadLine());

double[,] Creatarray = new double[m, n];
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
FillArray(Creatarray);
Console.WriteLine();
PrintArray(Creatarray);
