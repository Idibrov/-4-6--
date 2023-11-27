using System;

class Operation
{
    public static double CalculateTriangleArea(double side1, double side2, double side3)
    {
        if (IsTriangleValid(side1, side2, side3))
        {
            double p = (side1 + side2 + side3) / 2;
            return Math.Sqrt(p * (p - side1) * (p - side2) * (p - side3));
        }
        else
        {
            Console.WriteLine("Треугольник с такими сторонами не существует.");
            return 0;
        }
    }

    private static bool IsTriangleValid(double side1, double side2, double side3)
    {
        return side1 + side2 > side3 && side1 + side3 > side2 && side2 + side3 > side1;
    }

    public static double CalculateEquilateralTriangleArea(double side)
    {
        if (IsTriangleValid(side, side, side))
        {
            return (Math.Sqrt(3) / 4) * Math.Pow(side, 2);
        }
        else
        {
            Console.WriteLine("Равносторонний треугольник с такой стороной не существует.");
            return 0;
        }
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Выберите тип треугольника:");
        Console.WriteLine("1. Обычный треугольник");
        Console.WriteLine("2. Равносторонний треугольник");

        int choice = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1:
                Console.Write("Введите сторону A: ");
                double sideA = double.Parse(Console.ReadLine());

                Console.Write("Введите сторону B: ");
                double sideB = double.Parse(Console.ReadLine());

                Console.Write("Введите сторону C: ");
                double sideC = double.Parse(Console.ReadLine());

                double area = Operation.CalculateTriangleArea(sideA, sideB, sideC);
                Console.WriteLine($"Площадь треугольника: {area}");
                break;

            case 2:
                Console.Write("Введите сторону треугольника: ");
                double equilateralSide = double.Parse(Console.ReadLine());

                double equilateralArea = Operation.CalculateEquilateralTriangleArea(equilateralSide);
                Console.WriteLine($"Площадь равностороннего треугольника: {equilateralArea}");
                break;

            default:
                Console.WriteLine("Неверный выбор.");
                break;
        }
    }
}
