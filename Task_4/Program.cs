namespace Task_4;
/*
 * Створити класи Point та Figure. Клас Point повинен містити два цілих
 * поля і одне рядкове поле. Створити три властивості одним методом доступу get.
 * Створити власний конструктор, у тілі якого проініціалізуйте поля значеннями
 * аргументів. Клас Figure повинен містити конструктори, які приймають від 3 до
 * 5 аргументів типу Point. Створити два методи: double LengthSide(Point A, Point B),
 * що розраховує довжину сторони багатокутника; void PerimeterCalculator(), що
 * розраховує периметр багатокутника. Написати програму, яка виводить на екран
 * назву та периметр багатокутника.
 */
class Program
{
    static void Main(string[] args)
    {
        
        while (true)
        {
            Console.WriteLine("Введіть кількіст сторін фігури");
            Int32.TryParse(Console.ReadLine(), out int side);
            if (side < 3 || side > 5)
            {
                Console.WriteLine("Кількість сторін повинна бути >3 і <5 шт");
            }
            else
            {
                Point[] points = new Point[side];
                for (int i = 0; i < side; i++)
                {
                    Console.WriteLine($"Введіть Х для {i} відрізка");
                    Int32.TryParse(Console.ReadLine(), out int x);
                    Console.WriteLine($"Введіть У для {i} відрізка");
                    Int32.TryParse(Console.ReadLine(), out int y);
                    Console.WriteLine($"Введіть назву відрізка");
                    string name = Console.ReadLine();
                    points[i] = new Point(x, y, name);
                }
                Figure figure = new Figure(points);
                figure.PerimeterCalculator();
                Console.WriteLine(new string('*',30));
            }
            
        }
        
    }
}