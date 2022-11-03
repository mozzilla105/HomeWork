// Задание 15. Напишите программу,которая принмает на вход цифру,
//обозначающую день недели и проверяет,является ли этот день выходным.
Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine()!);
int weekday1 = 1;
int weekday2 = 2;
int weekday3 = 3;
int weekday4 = 4;
int weekday5 = 5;
int weekend1 = 6;
int weekend2 = 7;
if (0 < number && number < 8 && number == weekend1 || number == weekend2)
{
    Console.WriteLine("выходной!!!");
}
else if (0 < number && number < 8 && number == weekday1 || number == weekday2 || number == weekday3 || number == weekday4 || number == weekday5)
{
    Console.WriteLine("Невыходной(((");
}
else
{
    Console.WriteLine("Неверно(((");
}