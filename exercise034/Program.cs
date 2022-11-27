﻿// Задание 34. Задайте массив заполненный случайными положительными
// трёхзначными числами.Напишите программу,которая
// покажет количество чётных чисел в массиве
int[] ThreeDigitNumber(int size)
{
    int[] three_digit = new int[size];
    for (int i = 0; i < size; i++)
    {
       three_digit[i] = new Random().Next(100,1000); 
    }
    return three_digit;
}

int Quantity_of_EvenNumbers(int[] array)
{
    int count = 0;
    foreach (int element in array)
    {
       if(element % 2 == 0)
       {
        count ++;
       } 
    }
    return count;
}

Console.Write("Введите размер массива: ");
int number = int.Parse(Console.ReadLine()!);
int[] WorkingArray = ThreeDigitNumber(number);
Console.WriteLine($"Полученный массив: [{String.Join(",", WorkingArray)}]");
Console.Write($"Количество четных чисел в массиве: {Quantity_of_EvenNumbers(WorkingArray)}");