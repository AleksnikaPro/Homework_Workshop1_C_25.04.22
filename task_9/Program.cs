// Найти третью цифру числа или сообщить, что её нет.

Console.Write("Введите число до 10000: ");
int number = int.Parse(Console.ReadLine());
int result = number;

if (number > 99 && number < 999)
{
   Console.Write("Третья цифра введенного числа: ");
   Console.Write(result % 10);
}
else if (number > 1000 && number < 10000)
{
   Console.Write("Третья цифра введенного числа: ");
   Console.Write(result / 10 % 10);
}
else
{
   Console.WriteLine("Число содержит менее трёх цифр, поэтому найти третью цифру числа невозможно!");
}

