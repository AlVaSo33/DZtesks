
Console.WriteLine("Введите первое число: ");
int number1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе число: ");
int number2 = int.Parse(Console.ReadLine()!);

  int max = number1;
  int min = number2;
if (number1 > number2)
{
    Console.WriteLine("Большее число: " +  number1); 
    Console.WriteLine("Меньшее число: " +  number2);
}
if (number2 > number1)
{
    Console.WriteLine("Большее число: " +  number2);
    Console.WriteLine("Меньшее число: " +  number1);
}
if (number1 == number2)
{
  Console.WriteLine("Числа одинаковые");
}