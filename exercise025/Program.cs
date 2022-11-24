// Задание 25. Напишите цикл,который принимает на вход числа (А и В) и 
// и возводит А в натуральную степень В.
int Degree(int a, int b)
{
   
    int degree = 1;
    for (int i = 1; i <= b; i++)
    {
        degree = degree * a;
    }
    return degree;
}
Console.WriteLine("Введите первое число: ");
int N = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе число: ");
int M = int.Parse(Console.ReadLine()!);
Console.WriteLine(Degree(N,M));