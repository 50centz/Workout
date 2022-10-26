
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
/*
int[,] ArrangeItemsInDescendingOrder(int[,] array) // первый вариант сортировки
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int z = 1, r = 0; z < array.GetLength(1); z++, r++)
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
*/

int[,] ArrangeItemsInDescendingOrder(int[,] array) // Второй вариант сортировки
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0, r = 0; j < array.GetLength(1); j++, r++)
        {
            for (int z = 0; z < array.GetLength(1); z++)
            {
                if (array[i, r] > array[i, z])
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
Console.WriteLine();
Show2dArray(newArray);
Console.WriteLine();
ArrangeItemsInDescendingOrder(newArray);
Show2dArray(newArray);



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

void ShowArray(int[] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write(array[i] + " ");
    }
}


int[] TheRowWithTheSmallestSumOfElements(int[,] array)
{
    int sum = 0;

    int[] myArray = new int[array.GetLength(0)];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i, j];
        }
        myArray[i] = sum;
        sum = 0;
    }
    return myArray;
}

int[] TheRowWithTheSmallestSumOfElementsSum(int[] array)
{
    int[] myArray = new int[2];
    int min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        for (int r = 0; r < array.Length; r++)
        {
            if (array[r] < min)
            {
                min = array[r];
                myArray[1] = r + 1;
            }
        }
        myArray[0] = min;
    }
    return myArray;
}

int[,] myArray = Create2dArray();
Console.WriteLine();
Show2dArray(myArray);
Console.WriteLine();
int[] newArray = TheRowWithTheSmallestSumOfElements(myArray);
Console.WriteLine();
ShowArray(newArray);
Console.WriteLine();
int[] sumArray = TheRowWithTheSmallestSumOfElementsSum(newArray);
ShowArray(sumArray);
*/






// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц
