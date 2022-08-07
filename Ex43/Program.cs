/*Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем. */


void CheckCross(double b1, double k1, double b2, double k2)
{
    if (b1==b2 & k1==k2) Console.WriteLine("Прямые совпадают");
    else if (k1==k2) Console.WriteLine("Прямые параллельны друг другу");
    else
    {
        double xCross =  (b2 - b1) / (k1 - k2);
        double yCross = k1 * xCross + b1;
        Console.WriteLine($"Точка пересечения: ({xCross};{yCross})");
    }
}

Console.WriteLine("Введите через пробел значения точек двух прямых: b1 k1 b2 k2 ");
string[] array = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
double b1 = double.Parse(array[0]);
double k1 = double.Parse(array[1]);
double b2 = double.Parse(array[2]);
double k2 = double.Parse(array[3]);

CheckCross(b1, k1, b2, k2);
