namespace Geometry
{
    class Square: Shape
    {
        public void DrawSquare()
        {
            Console.WriteLine("Please, enter square size");

            if(int.TryParse(Console.ReadLine(), out int squareWidth))
                DrawShape(FillNumber(), squareWidth, squareWidth);
        }
    }
}