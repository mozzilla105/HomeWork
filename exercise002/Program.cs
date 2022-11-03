// Задача 2. Напишите программу,которая на вход принимает два числа и выдаёт,какое число большее,а какое маньшее.
Console.WriteLine("Введите первое число: ");
int number1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе число: ");
int number2 = int.Parse(Console.ReadLine()!);

if(number1 > number2)
{
    Console.WriteLine($"Максимальное число равно: {number1}");
    Console.WriteLine($"Минимальное число равно: {number2}");
}
else
{
    Console.WriteLine($"Максимальное число равно: {number2}");
    Console.WriteLine($"Минимальное число равно: {number1}");
}
