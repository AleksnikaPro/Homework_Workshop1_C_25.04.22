// Дано число из отрезка [10, 99]. Показать наибольшую цифру числа.

int number = new Random().Next(10, 99);
Console.Write("Число из отрезка: " );
Console.WriteLine(number);
int a = number / 10;
int b = number % 10;

if (a > b)
{
    Console.Write("Наибольшая цифра: ");
    Console.WriteLine(a);
}
if (b > a)
{
    Console.Write("Наибольшая цифра: ");
    Console.WriteLine(b);
}
if (a == b)
{
    Console.WriteLine("Цифры равны");
}



