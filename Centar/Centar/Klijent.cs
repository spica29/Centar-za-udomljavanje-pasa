using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Centar
{
    public class Klijent : Osoba
    {
        private Pas vlasnikPsa;
        private DateTime datumPreuzimanjaPsa;
        public Klijent()
        {
        }
        public Klijent(String jmb, String ime, String prezime, String adresa)
        {
        }
        public void Ispisi()
        {
        }
       /* public Pas DajPsa()
        {
        }*/
        public DateTime DajDatumPreuzimanjaPsa()
        {
            return datumPreuzimanjaPsa;
        }
    }
}