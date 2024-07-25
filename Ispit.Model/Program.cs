using Ispit.Model.Klase;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Ispit.Model
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;

            List<Proizvod> ListaProizvoda = new List<Proizvod>
            {
                new Proizvod ( 1, "Čokolada za kuhanje"),
                new Proizvod ( 2, "Lino Lada – Gold"),
                new Proizvod ( 3, "Papir za pečenje"),
                new Proizvod ( 4, "Brašno – pšenično"),
                new Proizvod ( 5,"Šećer - standard")
            };

            List<Racun> ListaRacuna = new List<Racun>
            {
                new Racun ( 100, 3, 800),
                new Racun ( 101, 2, 650),
                new Racun ( 102, 3, 900),
                new Racun ( 103, 4, 700),
                new Racun ( 104, 3, 900),
                new Racun ( 105, 4, 650),
                new Racun ( 106, 1, 458)
            };

            Console.WriteLine("Popis proizvoda:\n=================================================================================================");

            foreach (var proizvod in ListaProizvoda)
            {
                Console.WriteLine($"ID: {proizvod.ProizvodID}, Naziv: {proizvod.Naziv}");
            }

            Console.WriteLine("\nPopis računa:\n=================================================================================================");

            foreach (var racun in ListaRacuna)
            {
                Console.WriteLine($"Broj računa: {racun.BrojRacuna}, ID proizvoda: {racun.ProizvodID}, Količina: {racun.Kolicina}");
            }

            var SortiraniProizvodi = ListaProizvoda
                .OrderBy(ime => ime.Naziv);

            Console.WriteLine("\nPopis proizvoda nakon sortiranja po nazivu:\n=================================================================================================");

            foreach (var proizvod in SortiraniProizvodi)
            {
                Console.WriteLine($"ID: {proizvod.ProizvodID}, Naziv: {proizvod.Naziv}");
            }

            var ListaSpojenihPodataka = from proizvod in ListaProizvoda
                                        join proizvod2 in ListaRacuna
                                        on proizvod.ProizvodID equals proizvod2.ProizvodID
                                        select new
                                        {
                                            proizvod.ProizvodID,
                                            proizvod.Naziv,
                                            proizvod2.Kolicina
                                        };

            Console.WriteLine("\nPopis proizvoda nakon pridruživanja:\n");

            Console.WriteLine("ID Proizvoda\t\t\tNaziv proizvoda\t\t\t\tKupljena količina\n=================================================================================================");

            foreach (var podatak in ListaSpojenihPodataka)
            {
                Console.WriteLine($"{podatak.ProizvodID}\t\t\t\t{podatak.Naziv}\t\t\t{podatak.Kolicina}");
            }

            Console.ReadKey();
        }
    }
}
