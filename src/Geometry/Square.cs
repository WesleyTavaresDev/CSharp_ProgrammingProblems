class Square: Shape
{
    private override void DrawShape()
    {
        int squareWidth = int.Parse(Console.ReadLine());
        base.DrawShape(squareWidth, squareWidth);
    }
}