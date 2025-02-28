using System;
using System.Reflection;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;

class Cours
{
    static void Test()
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

        Console.WriteLine(Fonction(elt));
        Methode();
        /* 
            Accès           : public, protected, private, internal (possibilité de mélanger)
            Modificateurs   : abstract, sealed, virtual, unsafe
         */
        // ref; Référence pour éviter les effets de bord et créer une copie. Pour la lire et la modifier
        // in; Référence pour éviter les effets de bord et créer une copie. Pour la lire seulement
        // out; Référence p déclarer depuis l'extérieur ? Marce no entendi esto
    }
    public static string Fonction(string args, int entier = 0)
    {
        return $"la lettre {args} est différent de {entier}";
    }
    public static void Methode() => Console.WriteLine("haha");
}

public struct Voiture // Les structures sont faites pour des données pas trop complexe et qui ne changent quasiment pas. Privé par défaut
{                     // readonly; pour que lire sans pouvoir modifier
    public string Marque; // readonly;
    public int Nbr2places; // readonly;
    public Voiture(string marque, int nbr2places)
    {
        Marque = marque;
        Nbr2places = nbr2places;
    }
    public override string ToString() => $"Voiture de marque {Marque} avec {Nbr2places} places"; // readonly
}
public class Stock // abstract, abstract et partial no entendi Marce
{
    private int Capacity;
    public Stock()
    {
        Capacity = 10;
    }
    public Stock(int capacity)
    {
        Capacity = capacity;
    }
    public override string ToString() => $"Capacité du stock égal à {Capacity}";
}

namespace App
{
    
// Marce no entiendo porque tengo que tener un "namespace" para que los dos scripts se conecten
// o sino debo poner todo lo de encima en comentario
class Base
    {
        static void Main()
        {
            Stock st = new Stock();
            Console.WriteLine(st);
        }
    }
}
