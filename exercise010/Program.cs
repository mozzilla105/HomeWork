// Задание 10. Напишите программу,которая принмает на вход
// трёхзначное число и на выходе показывает вторую цифру этого числа.
Console.Clear();
int num = new Random().Next(100, 1000);

int num1 = num % 100;
int num2 = num1 / 10;

Console.WriteLine($"{num} -> {num2}");