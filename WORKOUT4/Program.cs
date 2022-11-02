
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


/*

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
*/


// C2.3. Найти:

/*

// а) среднее арифметическое всех целых чисел от 1 до 1000;

int sum = 0;
int counter = 0;
for (int i = 0; i < 1000; i++)
{
    sum += i;
    counter = i;
}
 int arithmeticMean = sum / counter;
Console.WriteLine(counter);
Console.WriteLine(sum);
Console.WriteLine(arithmeticMean);
*/


/*

// б) среднее арифметическое всех целых чисел от 100 до b (значение b вводится с клавиатуры; b>100);

Console.WriteLine("Input a digit: ");
int b = Convert.ToInt32(Console.ReadLine());

if (b < 100 || b == 100)
{
    Console.WriteLine("Enter a number above 100");
    return;
}

int sum = 0;
int counter = 0;

for (int i = 100; i < b; i++)
{
    sum += i;
    counter ++;
}

int arithmeticMean = sum / counter;
Console.WriteLine(sum);
Console.WriteLine(counter);
Console.WriteLine(arithmeticMean);
*/


/*

// в) среднее арифметическое всех целых чисел от a до 200 (значения a и b вводятся с клавиатуры; a<200);

Console.WriteLine("Input a digit: ");
int a = Convert.ToInt32(Console.ReadLine());

int sum = 0;
int counter = 0;

if (a > 200 || a == 200)
{
    Console.WriteLine("Enter a number less than 200");
}

for (int i = a; i < 200; i++)
{
    sum += i;
    counter++;
}

int arithmeticMean = sum / counter;

Console.WriteLine(arithmeticMean);
*/




// г) среднее арифметическое всех целых чисел от a до b (значения a и b вводятся с клавиатуры; b>a).

Console.WriteLine("Input a first digit: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a second digit: ");
int b = Convert.ToInt32(Console.ReadLine());

if ( a > b || a == b)
{
    Console.WriteLine("The first digit must be less than and not equal to the second digit");
    return;
}

int sum = 0;
int counter = 0;

for (int i = a; i < b; i++)
{
    sum += i;
    counter++;
}

int arithmeticMean = sum / counter;

Console.WriteLine(sum);
Console.WriteLine();
Console.WriteLine(counter);
Console.WriteLine();
Console.WriteLine(arithmeticMean);