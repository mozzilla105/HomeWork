//  Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

double[] InputParam() // ввод параметров линейных уравнений прямых
{
    double[] res = new double[4];
    /*  [0] -> k1,
     *  [1] -> b1,
     *  [2] -> k2,
     *  [3] -> b2
     */
    int n = 1;
    for (int i = 0; i < 4; i += 2)
    {
        Console.WriteLine($"{n}-е уравнение y = k{n} * x + b{n}");
        Console.Write($" k{n} = "); res[i] = double.Parse(Console.ReadLine());
        Console.Write($" b{n} = "); res[i + 1] = double.Parse(Console.ReadLine());
        n++;
    }
    return res;
}

double[]? PointsIntersectionOfStraightLines(double[] arg)
{
   
    if (arg[1] == arg[3] && arg[0] == arg[2]) //проверка на совпадение прямых k1=k2 и b1=b2
    {
        Console.WriteLine("Прямые совпадают. Точек пересечения бесконечное множество."); 
        return null;
    }
    if (arg[0] == arg[2])//проверка на параллельность k1=k2
    {
        Console.WriteLine("Прямые параллельны. Точек пересечения нет");
        return null;
    }


    //дальше вычисляем точку пересечения
    double[] res = new double[2]; 
    res[0] = (arg[3] - arg[1]) / (arg[0] - arg[2]);  
    res[1] = arg[0] * res[0] + arg[1];
    return res;
}


double[] parametryStraightLine = InputParam();
double[] point = PointsIntersectionOfStraightLines(parametryStraightLine);
if (point is null) return;
Console.WriteLine($"Точка пересечения ( {point[0]:F1} , {point[1]:F1} )");

