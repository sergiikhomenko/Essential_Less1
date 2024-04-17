using System.Text;

namespace Task2;
/*
 * Використовуючи Visual Studio, створіть проект за шаблоном Console Application. 
   Потрібно: Створити клас із ім'ям Rectangle. У тілі класу створити два поля, 
   що описують довжини сторін double side1, side2. Створити власний конструктор 
   Rectangle(double side1, double side2), у тілі якого поля side1 і side2 
   ініціалізуються значеннями аргументів. Створити два методи, що обчислюють 
   площу прямокутника - double AreaCalculator() та периметр прямокутника -
    double PerimeterCalculator(). Створити дві властивості double Area та 
    double Perimeter з одним методом доступу get. Написати програму, 
    яка приймає від користувача довжини двох сторін прямокутника і виводить 
    на екран периметр та площу. 
 */
class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            Console.WriteLine("Введіть першу сторону прямокутника");
            Double.TryParse(Console.ReadLine(), out double side1);
            
            Console.WriteLine("Введіть другу сторону прямокутника");
            Double.TryParse(Console.ReadLine(), out double side2);
            
            Rectangle rectangle = new Rectangle(side1, side2);
            Console.WriteLine($"Площа {rectangle.Area}");
            Console.WriteLine($"Периметр {rectangle.Perimeter}");
        }
    }
}