// Выяснить, кратно ли число заданному, если нет, вывести остаток.

Console.Write("Введите делимое число: ");
int numberA = int.Parse(Console.ReadLine());
Console.Write("Введите делитель числа: ");
int numberB = int.Parse(Console.ReadLine());

if (numberA % numberB == 0)
{
    Console.WriteLine("Число кратно заданному числу! ");
}
if (numberA % numberB != 0)
{
    Console.WriteLine("Число не кратно заданному числу! Остаток от деления: ");
    Console.WriteLine(numberA % numberB);
}
    




