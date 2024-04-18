namespace Tassk_3;
/*
 * git@github.com:sergiikhomenko/Essential_Less1.git
 *
 * Використовуючи Visual Studio, створіть проект за шаблоном Console Application.
 * Потрібно: Створити клас Book. Створити класи Title, Author та Content, кожен
 * з яких повинен містити одне рядкове поле та метод void Show(). Реалізуйте
 * можливість додавання до книги назви книги, імені автора та змісту.
 * Виведіть на екран різними кольорами за допомогою методу Show()
 * назву книги, ім'я автора та зміст.
 */
class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Введіть імя автора");
            string author = Console.ReadLine();
            Console.WriteLine("Введіть назву книги");
            string title = Console.ReadLine();
            Console.WriteLine("Введіть зміст");
            string conten = Console.ReadLine();
            Book book = new Book(author, conten, title);
            Console.WriteLine(new string('-',30));
            book.Show();
            Console.ForegroundColor = ConsoleColor.Black;
        }
    }
}