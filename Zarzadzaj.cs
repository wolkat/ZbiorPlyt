using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ZbiorPlyt
{
    class Zarzadzaj
    {
        public Plyta[] plyty;

        public string DodajPlyte(Plyta plyta) 
        {
            plyty[plyty.Length] = plyta;
            return "Dodano płyte";
        }

        public string DodajTytul() 
        {
            return "Dodano tytul";
        };
        public string DodajTyp() 
        { 
             return "Dodano typ";
        };
        public string DodajCzas() { };
        public Utwor[] DodajUtwory() { };
        public string[] DodajWykonawcow() { };
        public int DodajNr() { };
        

    }
}
