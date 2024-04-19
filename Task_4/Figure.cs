namespace Task_4;
/*
* Клас Figure повинен містити конструктори, які приймають від 3 до 5 аргументів типу Point.
* Створити два методи: double LengthSide(Point A, Point B),
* що розраховує довжину сторони багатокутника; void PerimeterCalculator(), що розраховує периметр багатокутника.
 */
public class Figure
{
    private Point[] points;

    public Figure(Point[] points)
    {
        this.points = points;
    }

    public double LengthSide(Point A, Point B)
    {
        return Math.Sqrt(Math.Pow(B.X - A.X, 2) + Math.Pow(B.Y - A.Y, 2));
    }

    public void PerimeterCalculator()
    {
        double perimeter = 0;
        for (int i = 0; i < points.Length; i++)
        {
            Point currentPoint = points[i];
            Point nextPoint = points[(i + 1) % points.Length];
            perimeter += LengthSide(currentPoint, nextPoint);
        }
        Console.WriteLine($"Периметер фігури: {perimeter}");
    }
}