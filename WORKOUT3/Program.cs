/*
// C1.22. Вывести «столбиком» следующие числа: 4,4,  4,6,  4,8,  …, 6,4.

for (double i = 4.4; i <= 6.4; i += 0.1)
{
    Console.WriteLine(Math.Round(i, 2));
}
*/


/*
// С5.1. Даны натуральные числа х и у. Вычислить произведение x·y, используя лишь операцию сложения. Задачу решить двумя способами.

int a = 5;
int y = 10;
int result = 0;

for (int i = 0; i < y; i++)
{
    result += a;
    Console.WriteLine(result);
}
*/


/*
// С5.2. Составить программу для расчета факториала натурального числа n (факториал числа n равен 1 ·2 · … · n ).

int a = 10;
int result = 1;

for (int i = 1; i <= a; i++)
{
    result *= i;
    Console.WriteLine(result);
}
*/


/*
// С5.3. В некоторых языках программирования (например, в C#) не предусмотрена операция возведения в степень. Составить программу для расчета степени n вещественного числа a (n — натуральное число).

double a = 2;
int b = 3;
double result = 1;

for (int i = 0; i < b; i++)
{
    result *= a;
    Console.WriteLine(result);
}
*/


/*
// С5.6. Найти сумму 1^2  + 2^2  + 3^2  + … + 10^2. Операцию возведения в степень не использовать, а учесть особенности получения квадрата натурального числа, отмеченные в предыдущей задаче.


int a = 10;
int result = 0;
int sum = 0;

for (int i = 1; i <= a; i++)
{
    sum = i * i;
    result += sum;
    Console.WriteLine(result);
}
*/



// С5.7.  Составить программу возведения натурального числа в третью степень, учитывая следующую закономерность:
// 1^3 = 1
// 2^3 = 3 + 5
// 3^3 = 7 + 9 + 11
// 4^3 = 13 + 15 + 17 + 19
// 5^3 = 21 + 23 + 25 + 27 + 29.

Console.WriteLine("Input a number: ");
int a = Convert.ToInt32(Console.ReadLine());

int c = a * a - (a - 1);

Console.Write(a + "^3 = ");

for (int i = 0; i < a - 1; i++)
{
    
    Console.Write(c + " + ");
    c += 2;
}
Console.Write(c);