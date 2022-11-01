
// C2.1. Найти:

/*

// а) сумму всех целых чисел от 100 до 500;

int sum = 0;

for (int i = 100; i < 500; i++)
{
    sum += i;
    Console.Write(sum + " ");
}
Console.WriteLine();
Console.WriteLine();
Console.WriteLine();
Console.WriteLine(sum);
*/


/*

// б) сумму всех целых чисел от a до 500 (значение a вводится с клавиатуры; a<500);

Console.WriteLine("Input a number: ");
int a = Convert.ToInt32(Console.ReadLine());

int sum = 0;

for (int i = a; i < 500; i++)
{
    sum += i;
    Console.Write(sum + " ");
}

Console.WriteLine();
Console.WriteLine();
Console.WriteLine();
Console.WriteLine(sum);
*/


/*

// в) сумму всех целых чисел от –10 до b (значение b вводится с клавиатуры; b>–10);

Console.WriteLine("Input a number: ");
int b = Convert.ToInt32(Console.ReadLine());

int sum = 0;

for (int i = -10; i < b; i++)
{
    sum += i;
    Console.Write(sum + " ");
}

Console.WriteLine();
Console.WriteLine();
Console.WriteLine();
Console.WriteLine(sum);
*/




// г) сумму всех целых чисел от a до b (значения a и b вводятся с клавиатуры; b>a).

Console.WriteLine("Enter a first digit: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter a second digit: ");
int b = Convert.ToInt32(Console.ReadLine());
int sum = 0;

if (a > b)
{
    Console.WriteLine("The first digit must be less than the second");
}
else
{
    for (int i = a; i < b; i++)
    {
        sum += i;
        Console.Write(sum + " ");
    }
    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine(sum);
}

