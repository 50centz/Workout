// C2.4. Найти:

/*

// а) сумму кубов всех целых чисел от 20 до 40;

int sum = 0;

for (int i = 20; i < 40; i++)
{
    double a = Math.Pow(i, 3);
    int b = (int)a;
    sum += b;
    Console.Write(b + " "); 
}

Console.WriteLine();
Console.WriteLine();
Console.WriteLine(sum);
*/


/*

// б) сумму квадратов всех целых чисел от a до 50 (значение a вводится с клавиатуры; 0<a<=50);

Console.WriteLine("Input a first digit: ");
int a = Convert.ToInt32(Console.ReadLine());

if (a < 0 || a == 0 || a > 50 || a == 50)
{
    Console.WriteLine("The first digit must be greater than zero and less than 50 ");
    return;
}

int sum = 0;
for (int i = a; i < 50; i++)
{
    int b = i * i;
    sum += b;
    Console.Write(b + " ");
}

Console.WriteLine();
Console.WriteLine();
Console.WriteLine(sum);
*/


/*

// в) сумму квадратов всех целых чисел от 1 до n (значение n вводится с клавиатуры; 1<=n<=100);

Console.WriteLine("Input a second digit: ");
int b = Convert.ToInt32(Console.ReadLine());

int sum = 0;

if (b <= 1 || b >= 100)
{
    Console.WriteLine("The second number must be between 1 and 100 ");
    return;
}

for (int i = 1; i < b; i++)
{
    int a = i * i;
    sum += a;
}

Console.WriteLine(sum);
*/




// г) сумму квадратов всех целых чисел от a до b (значения a и b вводятся с клавиатуры; b>a).

Console.WriteLine("Input a first digit: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a second digit: ");
int b = Convert.ToInt32(Console.ReadLine());

int sum = 0;

if(a > b)
{
    Console.WriteLine("The first digit cannot be greater than the second");
    return;
}

for (int i = a; i < b; i++)
{
    int x = i * i;
    sum += x;
    Console.Write(x + " ");
}
Console.WriteLine();
Console.WriteLine();
Console.WriteLine(sum);