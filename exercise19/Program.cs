/*Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18 */

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = new Random().Next(1, 9);
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i, j],3} \t");
        Console.WriteLine();
    }
}

int InputNum(string output)
{
    Console.Write(output);
    int input = Convert.ToInt32(Console.ReadLine());
    return input;
}

int numbers = InputNum("Введите размер для массивов: ");
int[,] massA = new int[numbers, numbers];
int[,] massB = new int[numbers, numbers];
FillArray(massA);
FillArray(massB);
int[,] massC = new int[numbers, numbers];

for (int i = 0; i < numbers; i++)
{
    for (int j = 0; j < numbers; j++)
    {
        for (int z = 0; z < numbers; z++)
        {
            massC[i, j] = massC[i, j] + (massA[i, z] * massB[z, j]);
        }
    }
}
Console.WriteLine("Массив A:");
PrintArray(massA);
Console.WriteLine();
Console.WriteLine("Массив B:");
PrintArray(massB);
Console.WriteLine();
Console.WriteLine("Произведение элементов в массивах A*B:");
PrintArray(massC);