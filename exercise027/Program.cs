// Задание 27. Напишите функцию и запишите её,
// которая принимает на вход число и выдаёт сумму цифр в числе.
int SumNum(int num)
{
    int result = 0;
    while(num != 0)
    {
        result = result + num%10;
        num = num/10;
    }
    return result;
}
int N = int.Parse(Console.ReadLine()!);
Console.WriteLine(SumNum(N));