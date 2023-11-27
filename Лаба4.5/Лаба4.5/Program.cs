using System;

class QuadraticEquation
{
    static int SolveQuadraticEquation(double a, double b, double c, out double x1, out double x2)
    {
        double discriminant = b * b - 4 * a * c;

        if (discriminant > 0)
        {
            x1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
            x2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
            return 1; // два корня
        }
        else if (discriminant == 0)
        {
            x1 = x2 = -b / (2 * a);
            return 0; // один корень
        }
        else
        {
            x1 = x2 = 0;
            return -1; // корней нет
        }
    }

    static void Main()
    {
        Console.Write("Введите коэффициент a: ");
        double a = double.Parse(Console.ReadLine());

        Console.Write("Введите коэффициент b: ");
        double b = double.Parse(Console.ReadLine());

        Console.Write("Введите коэффициент c: ");
        double c = double.Parse(Console.ReadLine());

        double x1, x2;

        int result = SolveQuadraticEquation(a, b, c, out x1, out x2);

        Console.Write($"Корней уравнения с коэффициентами a = {a}, b = {b}, c = {c}: ");

        if (result == 1)
        {
            Console.WriteLine($"Два корня: x1 = {x1}, x2 = {x2}");
        }
        else if (result == 0)
        {
            Console.WriteLine($"Один корень: x1 = x2 = {x1}");
        }
        else
        {
            Console.WriteLine("Корней нет");
        }
    }
}
 