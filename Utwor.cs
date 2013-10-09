using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ZbiorPlyt
{
    class Utwor
    {
        private string tytul;

        public string Tytul
        {
            get { return tytul; }
            set { tytul = value; }
        }
        private int czasTrwania;

        public int CzasTrwania
        {
            get { return czasTrwania; }
            set { czasTrwania = value; }
        }
        private string[] wykonawcy;

        public string[] Wykonawcy
        {
            get { return wykonawcy; }
            set { wykonawcy = value; }
        }
        private string kompozytor;

        public string Kompozytor
        {
            get { return kompozytor; }
            set { kompozytor = value; }
        }
        private int nr;

        public int Nr
        {
            get { return nr; }
            set { nr = value; }
        }
        
       
    }
}
