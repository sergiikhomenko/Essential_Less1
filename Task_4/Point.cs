namespace Task_4;
/*
 * Клас Point повинен містити два цілих
   * поля і одне рядкове поле. Створити три властивості одним методом доступу get.
   * Створити власний конструктор, у тілі якого проініціалізуйте поля значеннями
   * аргументів.
 */
public class Point
{
    private int _sideA, _sideB;
    private string _line;
    public int A
    {
        get { return _sideA; }
    }

    public int B
    {
        get { return _sideB; }
    }
    
    public string Line
    {
        get { return _line; }
    }

    public Point(int num1, int num2, string line)
    {
        _sideA = num1;
        _sideB = num2;
        _line = line;
    }
}