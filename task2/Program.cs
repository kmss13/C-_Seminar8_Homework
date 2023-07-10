// Задача 2: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
//Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

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


int rows = ReadInt("Введите количество строк >");
int columns = ReadInt("Введите количество столбцов >");
int[,] numbers = GenerateArray2D(rows, columns);
PrintArray2D(numbers);


int GetSumRows(int[,] array, int i)
{
    int sum = array[i, 0];

    for (int j = 1; j < numbers.GetLength(1); j++)
    {
        sum += array[i, j];
    }
    return sum;
}
int minSum = 1;
int sumAr = GetSumRows(numbers, 0);

for (int i = 1; i < numbers.GetLength(0); i++)
{
    if (sumAr > GetSumRows(numbers, i))
    {
        sumAr = GetSumRows(numbers, i);
        minSum = i + 1;
    }
}
System.Console.WriteLine($"Строка c наименьшей суммой элементов: {minSum}");



