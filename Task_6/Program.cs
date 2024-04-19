namespace Task_6;
/*
 * Використовуючи Visual Studio, створіть проект за шаблоном Console Application.
 * Потрібно: Створити клас із ім'ям Address. У тілі класу потрібно створити поля:
 * index, country, city, street, house, apartment. Для кожного поля створити
 * властивість з двома методами доступу. Створити екземпляр класу Address.
 * У поля екземпляра записати інформацію про поштову адресу.
 * Виведіть на екран значення полів, що описують адресу.
 */
class Program
{
    static void Main(string[] args)
    {
        Address address = new Address();
        address.Index = "42000";
        address.Country = "Україна";
        address.City = "Ромни";
        address.Street = "бул. Шевченка";
        address.House = "33";
        address.Apartment = "45B";
        
        
        Console.WriteLine($"Індекс: {address.Index}");
        Console.WriteLine($"Країна: {address.Country}");
        Console.WriteLine($"Місто: {address.City}");
        Console.WriteLine($"Вулиця: {address.Street}");
        Console.WriteLine($"Будинок: {address.House}");
        Console.WriteLine($"Квартира: {address.Apartment}");

    }
}