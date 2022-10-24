
// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

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

int[,] ArrangeItemsInDescendingOrder(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int r = 0, z = 1; z < array.GetLength(1); z++, r++)
            {

                if (array[i, r] < array[i, z])
                {
                    int temp = array[i, r];
                    array[i, r] = array[i, z];
                    array[i, z] = temp;
                }
            }

        }
    }
    return array;
}

int[,] newArray = Create2dArray();
Show2dArray(newArray);
Console.WriteLine();
int[,] myArr = ArrangeItemsInDescendingOrder(newArray);
Show2dArray(myArr);


/*
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
*/



// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц
