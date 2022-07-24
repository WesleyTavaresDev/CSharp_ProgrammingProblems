public class Geometry
{
    static void Main()
    {
        Console.WriteLine("----- Square -----");
        Square square = new Square();
        square.DrawSquare();

        Console.WriteLine("----- Rectangle -----");
        Rectangle rectangle = new Rectangle();
        rectangle.DrawRectangle();
    }
}