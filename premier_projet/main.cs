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
        bool test = false; // pas False
        test = true; // pas True
        Console.WriteLine(!test); // ! = not
        Console.WriteLine($"Hello World ! I'm {x} {moi}");
    }
}
