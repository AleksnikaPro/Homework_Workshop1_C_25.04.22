// Найти третью цифру числа или сообщить, что её нет.

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
int result = number / 100;

if (number > 99)
{
   Console.Write("Третья цифра введенного числа: ");
   Console.Write(result = result % 10);
}
else
{
   Console.WriteLine("Число содержит менее трёх цифр, поэтому найти третью цифру числа невозможно!");
}
   
