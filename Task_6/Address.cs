namespace Task_6;
/*
 * Створити клас із ім'ям Address.
 * У тілі класу потрібно створити поля: index, country, city, street, house, apartment.
 * Для кожного поля створити властивість з двома методами доступу.
 */
public class Address
{ 
    private string _index,_country, _city, _street, _house, _apartment;

    public string Index
    {
        set { _index  = value ?? throw new ArgumentNullException(nameof(value));}
        get { return _index; }
    }

    public string Country
    {
        get { return _country; }
        set { _country = value ?? throw new ArgumentNullException(nameof(value)); }
    }

    public string City
    {
        get { return _city; }
        set { _city = value ?? throw new ArgumentNullException(nameof(value)); }
    }
    
    public string Street
    {
        get { return _street; }
        set { _street = value ?? throw new ArgumentNullException(nameof(value)); }
    }

    public string House
    {
        get { return _house; }
        set { _house = value ?? throw new ArgumentNullException(nameof(value)); }
    }
    
    public string Apartment
    {
        get { return _apartment; }
        set { _apartment = value ?? throw new ArgumentNullException(nameof(value)); }
    }
    
}