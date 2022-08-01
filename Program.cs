using System;
using System.Collections;
using System.Collections.Generic;

namespace Csharp
{
    class Program
    {
        static void Main()
        {
            // system.collections.generic altında bulunur.
            Dictionary<int, string> liste = new Dictionary<int, string>();

            liste.Add(5, "Masaüstü");
            liste.Add(6, "Laptop");
            liste.Add(7, "Konsol");
            liste.Add(8, "Telefon");

            // Dizinin elemanlarına erişim

            Console.WriteLine("**** Elemanlara Erişim ****");

            Console.WriteLine(liste[5]);

            foreach (var item in liste)
                Console.WriteLine(item);

            // Count

            Console.WriteLine("**** Count ****");

            Console.WriteLine(liste.Count);

            // Contains

            Console.WriteLine("**** Contains ****");

            Console.WriteLine(liste.ContainsValue("Masaüstü"));
            Console.WriteLine(liste.ContainsKey(9));

            // Remove

            Console.WriteLine("**** Remove ****");

            liste.Remove(5);

            foreach (var item in liste)
                Console.WriteLine(item.Key);

            // Keys 

            Console.WriteLine("**** Keys ****");

            foreach (var item in liste.Keys)
                Console.WriteLine(item);

            // Values

            Console.WriteLine("**** Values ****");

            foreach (var item in liste.Values)
                Console.WriteLine(item);
        }
    }
}