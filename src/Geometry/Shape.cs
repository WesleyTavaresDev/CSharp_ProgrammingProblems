using System;

class Shape
{
    protected virtual void DrawShape(int fillNumber, int width, int height)
    {
        for(int i = 0; i < height; i++)
        {   
            for(int j = 0; j < width; j++)
                Console.Write(fillNumber); 
            Console.Write('\n');
        }
    }

    protected int FillNumber()
    {
        Console.WriteLine("Please enter fill shape number: ");


        if(int.TryParse(Console.ReadLine(), out int fillNumber))
            return fillNumber;
        else
            return 0;
    }
}