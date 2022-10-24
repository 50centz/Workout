
// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

int[,] Create2dArray()
{
    Console.WriteLine("Enter the number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter the number of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter the beginning of the array range: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter the end of the array range: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int[rows, columns];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return array;
}

void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}


int TheRowWithTheSmallestSumOfElements(int[,] array)
{
    int sum = 0;
    int sumMin = 100;
    int count = 0;

    for (int i = 0; i < array.GetLength(0); i++)
    {

        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i, j];
        }
        if (sumMin >= sum)
        {
            sumMin = sum;
            count = i;
        }
        sum = 0;
    }
    return count + 1;
}

int TheRowWithTheSmallestSumOfElementsSum(int[,] array)
{
    int sum = 0;
    int sumMin = 100;


    for (int i = 0; i < array.GetLength(0); i++)
    {

        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i, j];
        }
        if (sumMin >= sum) sumMin = sum;
        sum = 0;
    }
    return sumMin;
}

int[,] myArray = Create2dArray();
Console.WriteLine();
Show2dArray(myArray);
Console.WriteLine();
int rows = TheRowWithTheSmallestSumOfElements(myArray);
int minSum = TheRowWithTheSmallestSumOfElementsSum(myArray);

Console.Write($"{minSum} and {rows}");

