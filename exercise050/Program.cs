//Задача 50. Напишите программу, которая на вход принимает число и ищет его в двумерном массиве. 
//Программа должна возвращать значение позиции (номер строки и столбца) этого элемента или же указание, что такого элемента нет.



bool SearchNumberInArray(int[,] array, int findNumber)
{

    bool isFound = false;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] == findNumber)
            {
                Console.Write((isFound ? "" : "Найдено:\n"));
                Console.WriteLine($"[{i},{j}]");
                isFound = true;
            }
        }
    }
    return isFound;
}




int[,] myTestArray = { { 12, 4, 17, 32 },
                       { 5, 9, 24, 1 },
                       { 8, 5, 2, 14}};

Console.WriteLine("Введите число для поиска: ");
int findNum = int.Parse(Console.ReadLine());
bool resultSearch = SearchNumberInArray(myTestArray, findNum);
if (!resultSearch)
{
    Console.WriteLine($"Элемент со значением {findNum} не найдены");
}
