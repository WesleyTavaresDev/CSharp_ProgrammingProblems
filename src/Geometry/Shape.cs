using System;

class Shape
{
    public virtual void DrawShape(int width, int height)
    {
        Console.WriteLine("Please enter a number: ");

        int number  = int.Parse(Console.ReadLine());

        for(int i = 0; i < height; i++)
        {
            for(int j = 0; j < width; j++)
                Console.Write(number);
                    
            Console.Write('\n');
        }
    }
}