// Показать вторую цифру трёхзначного числа.

Console.Write("Введите трёхзначное число: ");
int number =  int.Parse(Console.ReadLine());
int result = number / 10;
if (number > 99 && number < 1000)
{
Console.Write("Вторая цифра трёхзначного числа: ");
Console.Write(result = result % 10);
}
else
{
    Console.WriteLine("Число не трёхзначное!");
}

