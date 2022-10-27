/*
// C1.13. Напечатать таблицу умножения на 7

for (int i = 0; i < 9; i++)
{
    Console.WriteLine($"{i + 1} * 7 = {(i + 1) * 7} ");
}
*/


/*
// C1.7. Одна штука некоторого товара стоит 55,99 руб. Напечатать таблицу стоимости 2, 3, …, 20 штук этого товара.

double a = 55.99;
for (int i = 0; i < 20; i++)
{
    Console.WriteLine($"{i + 1} * {a} = {(i + 1) * a}");    
}
*/


/*
// C1.8. Напечатать таблицу соответствия между весом в фунтах и весом в килограммах для значений 1, 2, …, 10 фунтов (1 фунт = 453 г).
double a = 0.453;

for (int i = 0; i < 10; i++)
{
    if (i < 1) Console.WriteLine($"{i + 1} фунт равен {a} килограмма ");
    else if (i < 4 ) Console.WriteLine($"{i + 1} фунта равно {Math.Round((i + 1) * a, 2)} килограмма");
    else if (i < 10) Console.WriteLine($"{i + 1} фунтов равно {Math.Round((i + 1) * a, 2)} килограмма");
}
*/



// C1.10. Напечатать таблицу перевода 1, 2, … 20 долларов США в рубли по текущему курсу (значение курса вводится с клавиатуры).

Console.WriteLine("Input dollar rate: ");
double dollarRate = Convert.ToDouble(Console.ReadLine());

for (int i = 0; i < 20; i++)
{
    if (i < 1) Console.WriteLine($"{(i + 1)} $ equal to {dollarRate} rub.");
    else if (i < 20) Console.WriteLine($"{(i + 1)} $ equal to {Math.Round((i + 1) * dollarRate, 2)} rub.");
}