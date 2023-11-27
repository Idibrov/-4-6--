using System;

class Triangle
{
    private double sideA;
    private double sideB;
    private double sideC;

    public void InitializeSides(double a, double b, double c)
    {
        if (IsValidTriangle(a, b, c))
        {
            sideA = a;
            sideB = b;
            sideC = c;
        }
        else
        {
            Console.WriteLine("Треугольник с такими сторонами не существует.");
        }
    }

    public double CalculatePerimeter()
    {
        return sideA + sideB + sideC;
    }

    public double CalculateArea()
    {
        double halfPerimeter = CalculatePerimeter() / 2;
        return Math.Sqrt(halfPerimeter * (halfPerimeter - sideA) * (halfPerimeter - sideB) * (halfPerimeter - sideC));
    }

    public void DisplaySides()
    {
        Console.WriteLine($"Стороны треугольника: {sideA}, {sideB}, {sideC}");
    }

    private bool IsValidTriangle(double a, double b, double c)
    {
        return a + b > c && a + c > b && b + c > a;
    }
}

class Program
{
    static void Main()
    {
        Triangle triangle = new Triangle();

        Console.Write("Введите длину стороны A: ");
        double sideA = double.Parse(Console.ReadLine());

        Console.Write("Введите длину стороны B: ");
        double sideB = double.Parse(Console.ReadLine());

        Console.Write("Введите длину стороны C: ");
        double sideC = double.Parse(Console.ReadLine());

        triangle.InitializeSides(sideA, sideB, sideC);

        if (triangle.CalculatePerimeter() > 0)
        {
            Console.WriteLine($"Периметр треугольника: {triangle.CalculatePerimeter()}");
            Console.WriteLine($"Площадь треугольника: {triangle.CalculateArea()}");
            triangle.DisplaySides();
        }
    }
}
