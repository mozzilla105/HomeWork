// Задание 29. Напишите программу,которая задаёт
// массив из 8 элементов и выдаёт их на экран.
int FillArray(int[] mass)
{
    int length = mass.Length;
    for (int i = 0; i < length; i++)
    {
        mass[i] = int.Parse(Console.ReadLine()!);
    }
    return length;
}
int PrintArray(int[] col)
{
    int count = col.Length;
    for (int ind = 0; ind < count-1; ind++)
    {
        Console.Write($"{col[ind]},");
    }
    Console.Write(col[7]);
    return count;
}
Console.WriteLine("Введите элементы массива");
int[] array = new int [8];
FillArray(array);
Console.Write("Массив: [");
PrintArray(array);
Console.Write("]");