using System;
using System.Collections.Generic;
using System.IO;

namespace HarcosProject_BertalanGergo
{
    class Program
    {
        static List<Harcos> lista = new List<Harcos>();
        static Harcos FelhasznaloHarcosa;
        static Random rnd = new Random();
        static void Main(string[] args)
        {
            StatikusFeltoltes();
            Kiir();
            JatekKezdete();
            KorKiir();
            HarcosMegkuzd();
            veletlenEllenseg();

            Console.ReadKey();
        }


        private static Harcos veletlenEllenseg()
        {
            return lista[rnd.Next(lista.Count)];

        }
        private static Harcos HarcosMegkuzd()
        {
            int valasz = 0;

            while (valasz == 0)
            {
                try
                {
                    Console.WriteLine("Válassza ki azt a harcost akivel meg szeretne küzdeni");

                    valasz = int.Parse(Console.ReadLine());
                    if (valasz < 1 || valasz > lista.Count)
                    {
                        Console.WriteLine("Hiba: Ilyen sorszámú harcos nincsen, adjon meg egy másik számot. ");
                    }

                }
                catch (Exception)
                {
                    Console.WriteLine("Hiba: Nem számot adott meg, adjon meg egy számot.");
                }
            }
            return lista[valasz - 1];
        }

        private static string valasztas()
        {
            string valasz;
            do
            {
                Console.WriteLine("Kérem adja meg a választ");
                Console.WriteLine("a, Megküzdeni egy harcossal");
                Console.WriteLine("b, Gyógyul");
                Console.WriteLine("c, Kilép");
                valasz = Console.ReadLine();
            } while (!(valasz != "a" || valasz != "b" || valasz != "c"));

            return valasz;
        }
        private static void KorKiir()
        {
            Console.WriteLine();
            Console.WriteLine("Jatékos Harcosa: {0}", FelhasznaloHarcosa);
            for (int i = 0; i < lista.Count; i++)
            {
                Console.WriteLine("{0} - {1}", i + 1, lista[i]);
            }
        }
        private static void JatekKezdete()
        {
            Console.WriteLine();
            Console.Write("Kérem adja meg a Harcosa nevét: ");
            string nev = Console.ReadLine();
            Console.Write("Kérem adja meg a státusz sablonját (1 vagy 2 vagy 3): ");
            int sablon = int.Parse(Console.ReadLine());
            FelhasznaloHarcosa = new Harcos(nev, sablon);
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
