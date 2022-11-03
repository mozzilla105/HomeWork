// Задача 6 Напишите программу,которая на вход принимает число и выдаёт,является ли число чётным.
Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine()!);

if(number%2 == 0)
{
    Console.WriteLine("Число является чётным");
}
else
{
    Console.WriteLine("Число является нечётным");  
}