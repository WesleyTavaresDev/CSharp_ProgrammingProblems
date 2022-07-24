class Triangle: Shape
{
  public void DrawTriangle()
  {
    int fillNumber = FillNumber();

    Console.WriteLine("Please enter triangle size");

    if(int.TryParse(Console.ReadLine(), out int triangleSize))
    {
      int triangleHeight = triangleSize;

      for(int i = 0; i < triangleHeight; i++)
      {
        for(int j = triangleSize; j > 0; j--)
          Console.Write(fillNumber);
        triangleSize--;
        Console.Write('\n');
      }
    }

  }
}