// Задача 3: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// 2 4 | 3 4 2
// 3 2 | 3 3 1
// Результирующая матрица будет:
// 18 20 8
// 15 18 7

int ReadInt(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}



int[,] GenerateArray2D(int rows, int columns)
{
    int[,] numbers = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        for (int j = 0; j < numbers.GetLength(1); j++)
        {
            numbers[i, j] = rnd.Next(0, 10);
        }
    }
    return numbers;
}

void PrintArray2D(int[,] numbers)
{
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        for (int j = 0; j < numbers.GetLength(1); j++)
        {
            System.Console.Write($"{numbers[i, j]}\t");
        }
        System.Console.WriteLine();
    }
}

int rows1 = ReadInt("Введите количество строк первого массива >");
int columns1 = ReadInt("Введите количество столбцов первого массива >");

int rows2 = ReadInt("Введите количество строк второго массива>");
int columns2 = ReadInt("Введите количество столбцов второго массива>");

int[,] ArrayFirst = GenerateArray2D(rows1, columns1);
PrintArray2D(ArrayFirst);
Console.WriteLine();
int[,] ArraySecond = GenerateArray2D(rows2, columns2);
PrintArray2D(ArraySecond);


int[,] resultArray = new int[rows1,columns2];
MultiplyArrays(ArrayFirst, ArraySecond, resultArray);



void MultiplyArrays(int[,] array1, int[,] array2, int[,] array)
{
    if (ArrayFirst.GetLength(1) != ArraySecond.GetLength(0))
    {
       Console.WriteLine("Умножение не возможно! Количество столбцов первого массива не равно количеству строк второго массива.");
       return;
   }

    for (int i = 0; i < resultArray.GetLength(0); i++)
    {
        for (int j = 0; j < resultArray.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < ArrayFirst.GetLength(1); k++)
            {
                sum += ArrayFirst[i, k] * ArraySecond[k, j];
            }
            resultArray[i, j] = sum;
            
        }
    }
    Console.WriteLine("Произведение первого и второго массивов: ");
    PrintArray2D(resultArray);

}










