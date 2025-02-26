using System;
using System.Security.Cryptography;

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
        
        int nbr = 1;
        if(nbr < 0)
            Console.WriteLine($"nbr = {nbr}\tNégatif");
        else if(nbr == 0) // else if = elif
            Console.WriteLine($"nbr = {nbr}");
        else
        {
            Console.Write($"nbr = {nbr}");
            Console.WriteLine("\tPositif");
        }

        string nom = "azerty";
        switch(nom) // Le "switch" dans d'autre langage ne marche pas forcément pour les string
        {
            case "qwerty":
                Console.WriteLine($"Ton nom est {nom}");
                break;
            case "azerty":
                Console.WriteLine($"Ton nom est {nom}");
                break;
            default:
                Console.WriteLine($"Ton nom est {nom} mais tom nom est incorrect");
                break;
        }

        int val = 0;
        bool result = (val == 0) ? true : false;
        // if(val == 0)
        //     bool result = true;
        // else
        //     bool result = false;
        Console.WriteLine(result);

        int i = 0;
        while(i < 5)
        {
            Console.WriteLine("mot");
            i++;
        }

        int j = 5;
        do
        {
            Console.WriteLine("autre");
            i++;
        }
        while(j < 5);

        for(int k = 0; k < 10; k++)
        {
            Console.WriteLine("ici");
            if(k == 5)
                continue; // break mais relance la boucle
            Console.WriteLine("là");
        }

        string elt = "alpha";
        foreach(char lettre in elt)
        {
            Console.WriteLine(lettre);
        }

        string? text = Console.ReadLine(); // Le ? permet de déclarer une variable nullable (pas obligatoire)
        string texte = Console.ReadLine() ?? "Valeur par défaut";  // Si Console.ReadLine() retourne null,
                                                                   // "Valeur par défaut" est assigné (pas obligatoire)
        Console.WriteLine(text + "\n" + texte);
    }
}
