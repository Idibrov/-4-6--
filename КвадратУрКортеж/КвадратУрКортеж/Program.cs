using System;

class QuadraticEquation
{
    static (int result, double x1, double x2) SolveQuadraticEquation(double a, double b, double c)
    {
        double discriminant = b * b - 4 * a * c;

        if (discriminant > 0)
        {
            double x1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
            double x2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
            return (1, x1, x2); // два корня
        }
        else if (discriminant == 0)
        {
            double x1 = -b / (2 * a);
            return (0, x1, x1); // один корень
        }
        else
        {
            return (-1, 0, 0); // корней нет
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

        var resultTuple = SolveQuadraticEquation(a, b, c);

        Console.Write($"Корней уравнения с коэффициентами a = {a}, b = {b}, c = {c}: ");

        if (resultTuple.result == 1)
        {
            Console.WriteLine($"Два корня: x1 = {resultTuple.x1}, x2 = {resultTuple.x2}");
        }
        else if (resultTuple.result == 0)
        {
            Console.WriteLine($"Один корень: x1 = x2 = {resultTuple.x1}");
        }
        else
        {
            Console.WriteLine("Корней нет");
        }
    }
}
