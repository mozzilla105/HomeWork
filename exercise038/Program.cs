﻿// Задание 38. Задайте массив вещественныъ чисел.
// Найдите разницу между максимальным и минимальным элементом.

double[] Returns_Array(int size, int left, int right)
{
    double[] vector = new double[size];
    for (int i = 0; i < size; i++)
    {
        vector[i] = Math.Round(new Random().NextDouble() * (right - left) + left, 5);
    }
    return vector;
}

double MaxElement(double[] array)
{
    double max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
       if(array[i] > max)
       {
        max = array[i];
       } 
    }
    return max;
}

double MinElement(double[] array)
{
    double min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] < min)
        {
            min = array[i];
        }
    }
    return min;
}

Console.Write("Введите размер массива: ");
int number = int.Parse(Console.ReadLine()!);
Console.Write("Введите значение левого конца диапазона: ");
int a = int.Parse(Console.ReadLine()!);
Console.Write("Введите значение правого конца диапазона: ");
int b = int.Parse(Console.ReadLine()!);
double[] WorkingArray = Returns_Array(number,a,b);
Console.WriteLine($"Полученный массив: [{String.Join(",", WorkingArray)}]");

Console.WriteLine($"Наименьший элемент массива: {MinElement(WorkingArray)}");
Console.WriteLine($"Наибольший элемент массива: {MaxElement(WorkingArray)}");

double sum = MaxElement(WorkingArray) + MinElement(WorkingArray);
Console.WriteLine($"Сумма наименьшего и наибольше элементов массива равна {sum}");
