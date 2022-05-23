using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;
using Ispit.Model;
using Ispit.Model.Klase;

namespace Ispit.Konzola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GrupirajPremaBanci();
            IzvjestajMilijunasa();
        }

        private static void GrupirajPremaBanci()
        {
            var grupiraniMilijunasi = new GrupiraniMilijunasi();
            var podaci = new Podaci();

            var grupirajPremaBanci = podaci.ListaKlijenata
                .Where(x => x.Stanje > 999999.99)
                .GroupBy(y => y.Simbol)
                .ToList();


            foreach (var item in grupirajPremaBanci)
            {
                grupiraniMilijunasi.Banka = item.Key;
                Console.WriteLine($"Banka: {grupiraniMilijunasi.Banka}");

                foreach (var klijent in item)
                {
                    grupiraniMilijunasi.Milijunasi = klijent.ImePrezime;
                    Console.WriteLine(grupiraniMilijunasi.Milijunasi);
                }
            }
        }

        private static void IzvjestajMilijunasa()
        {
            var podaci1 = new Podaci().ListaKlijenata;
            var izvjestajMilijunasa = podaci1.Where(x => x.Stanje > 999999.99).ToList();

            foreach (var item in izvjestajMilijunasa)
            {
                Console.WriteLine($"{item.ImePrezime} je u {item.Simbol}");
            }
        }
    }
}
