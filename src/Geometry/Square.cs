class Square: Shape
{
    public void DrawSquare()
    {
        Console.WriteLine("Please, enter square size");
        int squareWidth = int.Parse(Console.ReadLine());
        
        DrawShape(squareWidth, squareWidth);
    }
}