using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Centar
{
    public abstract class Osoba
    {
        private String jmb;
        private String ime;
        private String prezime;
        private String adresa;

        public Osoba()
        {
        }

        public Osoba(string _jmb,string _ime,string _prezime,string _adresa)
        {
            jmb = _jmb;
            ime = _ime;
            prezime = _prezime;
            adresa = _adresa;
        }

        public virtual string dajIme() { return ime; }
    }
}
