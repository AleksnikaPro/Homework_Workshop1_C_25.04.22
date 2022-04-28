// По двум заданным числам проверять является ли первое квадратом второго.

Console.Write("Введите первое число: ");
int a =  int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int b =  int.Parse(Console.ReadLine());

if (b == a * a)
{
    Console.Write("Первое число является квадратом второго числа ");
}
else
{
   Console.Write("Первое число не является квадратом второго числа ");
} 


