using System;

class Shape
{
    protected virtual void DrawShape(int width, int height)
    {
        Console.WriteLine("Please enter a number: ");

        if(int.TryParse(Console.ReadLine(), out int inputNumber))
        {
            for(int i = 0; i < height; i++)
            {   
                for(int j = 0; j < width; j++)
                    Console.Write(inputNumber); 
                Console.Write('\n');
            }
        }
    }
}