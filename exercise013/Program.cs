// Напишите программу,которая выводит третью цифру заданного числа
//или сообщает,что третьей цифры нет.
Console.WriteLine("Введите число: ");
int num1 = int.Parse(Console.ReadLine()!);

if (num1 / 100 >= 1)
{
    while (num1 > 1000)
    {
        num1 = num1 / 10;
    }
    int num3 = num1 % 10;
    Console.WriteLine(num3);
}
else
{
    Console.WriteLine("Ваше число меньше чем трёхзначное.");
}


