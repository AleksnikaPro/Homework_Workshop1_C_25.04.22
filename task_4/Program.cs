// Показать четные числа от 1 до N.

Console.Write("Введите число: ");
int number =  int.Parse(Console.ReadLine());
int digit = 1;

while(digit <= number)
{
    if (digit % 2 == 0)
    {
      Console.Write("Четные числа от 1 до указанного Вами числа: ");
      Console.WriteLine(digit);
      
    }
    digit++;
}

