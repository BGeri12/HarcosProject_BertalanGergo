using System;
using System.Collections.Generic;
using System.IO;

namespace HarcosProject_BertalanGergo
{
    class Program
    {
        static List<Harcos> lista = new List<Harcos>();
        static void Main(string[] args)
        {
            StatikusFeltoltes();
            Kiir();

            Console.ReadKey();
        }

        private static void Kiir()
        {
            for (int i = 0; i < lista.Count; i++)
            {
                Console.WriteLine(lista[i]);
            }
        }
        private static void StatikusFeltoltes()
        {
            Harcos harcos1 = new Harcos("Jancsi", 2);
            Harcos harcos2 = new Harcos("Pisti", 3);
            Harcos harcos3 = new Harcos("Karoly", 1);
            lista.Add(harcos1);
            lista.Add(harcos2);
            lista.Add(harcos3);
        }
    }
}
