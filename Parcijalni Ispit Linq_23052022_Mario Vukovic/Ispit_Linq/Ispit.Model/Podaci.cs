using System;
using System.Collections.Generic;
using Ispit.Model.Klase;

namespace Ispit.Model
{
    public class Podaci : Klijent
    {
        public List<Banka> ListaBanki = new()
        {
            new Banka { Naziv = "Privredna Banka Zagreb", Simbol = "PBZ" },
            new Banka { Naziv = "Zagrebacka Banka", Simbol = "ZABA" },
            new Banka { Naziv = "Hrvatska Postanska Banka", Simbol = "HPB" }
        };

        public List<Klijent> ListaKlijenata = new()
        {
            new Klijent {ImePrezime = "ImePrezime1", Stanje = 197891.54, Simbol = "ZABA"},
            new Klijent {ImePrezime = "ImePrezime2", Stanje = 541871.56, Simbol = "PBZ"},
            new Klijent {ImePrezime = "ImePrezime3", Stanje = 258741.66, Simbol = "HPB"},
            new Klijent {ImePrezime = "ImePrezime4", Stanje = 774156.87, Simbol = "ZABA"},
            new Klijent {ImePrezime = "ImePrezime5", Stanje = 1258741.36, Simbol = "HPB"},
            new Klijent {ImePrezime = "ImePrezime6", Stanje = 1297551.74, Simbol = "PBZ"},
            new Klijent {ImePrezime = "ImePrezime7", Stanje = 6542581.65, Simbol = "ZABA"},
            new Klijent {ImePrezime = "ImePrezime8", Stanje = 1475668.88, Simbol = "HPB"},
            new Klijent {ImePrezime = "ImePrezime9", Stanje = 5477999.44, Simbol = "PBZ"},
            new Klijent {ImePrezime = "ImePrezime10", Stanje = 4458715.31, Simbol = "ZABA"},
        };
    }
}



