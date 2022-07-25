namespace Geometry
{
    public class Geometry
    {
        public void DrawGeometricShapes()
        {
            Console.WriteLine("------ Geometry exercise ------");

            Console.WriteLine("----- Square -----");
            Square square = new Square();
            square.DrawSquare();

            Console.WriteLine("----- Rectangle -----");
            Rectangle rectangle = new Rectangle();
            rectangle.DrawRectangle();

            Console.WriteLine("----- Triangle -----");
            Triangle triangle = new Triangle();
            triangle.DrawTriangle();
        }
    }
}