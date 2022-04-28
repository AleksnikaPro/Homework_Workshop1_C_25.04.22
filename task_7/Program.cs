Console.Write("Введите трёхзначное число: ");
int number =  int.Parse(Console.ReadLine());
int result = number / 10;
if (number > 99 && number < 1000)
{
Console.Write("Вторая цифра трёхзначного числа: ");
Console.WriteLine(result = result % 10);
Console.WriteLine("Результат удаления второй цифры из трёхзначного числа: ");
Console.Write((number /100) * 10 + number % 10);
}
else
{
    Console.WriteLine("Число не трёхзначное!");
}
   