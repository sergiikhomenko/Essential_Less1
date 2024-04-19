namespace Task_4;
/*
 * Клас Point повинен містити два цілих
   * поля і одне рядкове поле. Створити три властивості одним методом доступу get.
   * Створити власний конструктор, у тілі якого проініціалізуйте поля значеннями
   * аргументів.
 */
public class Point
{
    private int _x, _y;
    private string _line;
    public int X
    {
        get { return _x; }
    }

    public int Y
    {
        get { return _y; }
    }
    
    public string Line
    {
        get { return _line; }
    }

    public Point(int num1, int num2, string line)
    {
        _x = num1;
        _y = num2;
        _line = line;
    }
}