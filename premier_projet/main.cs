using System;

class Program
{
    static void Main(string[] args)
    {
        string moi = "azerty";
        int x = 0;
        x++; // x += 1;
        // x++ != ++x; priorité en fonction si c'est un sufixe ou un préfixe
        // WriteLine(++x)      =       WriteLine(x + 1);
        // WriteLine(x++)      =       WriteLine(x);  x += 1;
        Console.WriteLine($"Hello World ! I'm {x} {moi}");

        bool test = false; // pas False
        test = true; // pas True
        Console.WriteLine(!test); // ! = not

        Console.WriteLine(4 == 4 && 3 == 2); // && = and
        Console.WriteLine(4 == 4 || 2 == 3); // || = or

        bool y = false;
        if(y == true)
            Console.WriteLine($"y est {y}");
        else
            Console.WriteLine($"y est {y}");
        
        int nbr = -1;
        if(nbr < 0)
            Console.WriteLine($"nbr = {nbr}");
        else
        {
            Console.Write($"nbr = {nbr}");
            Console.WriteLine("\tPositif");
        }
    }
}
