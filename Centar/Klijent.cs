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
        private Pas _vlasnikPsa;

        public Pas vlasnikPsa
        {
            get { return _vlasnikPsa; }
            set { _vlasnikPsa = value; }
        }

        private DateTime _datumPreuzimanjaPsa;
        private int p1;
        private string p2;
        private string p3;
        private string p4;
        private string p5;
        private int p6;
        private DateTime dateTime;

        public DateTime datumPreuzimanjaPsa
        {
            get { return _datumPreuzimanjaPsa; }
            set { _datumPreuzimanjaPsa = value; }
        }
        public Klijent()
        {
        }
        public Klijent(String _jmb, String _ime, String _prezime, String _adresa, Pas _vlasnikPsa, DateTime _datumPreuzimanja)
            : base(_jmb, _ime, _prezime, _adresa)
        {
            PasDAO p = new PasDAO("localhost", "Centar", "root", "");
            List<Pas> pas = new List<Pas>();
            pas = p.getByExample(Convert.ToString(_vlasnikPsa.id));
            vlasnikPsa = pas[0];
            datumPreuzimanjaPsa = _datumPreuzimanja;
        }

        public Klijent(String _jmb, String _ime, String _prezime, String _adresa, Int32 _idVlasnikPsa, DateTime _datumPreuzimanja)
            : base(_jmb, _ime, _prezime, _adresa)
        {
            PasDAO p = new PasDAO("localhost", "Centar", "root", "");
            Pas pas = new Pas();
            pas = p.getById(_idVlasnikPsa);

            vlasnikPsa = pas;
            datumPreuzimanjaPsa = _datumPreuzimanja;
        }

        public Klijent(int id, String _jmb, String _ime, String _prezime, String _adresa, Int32 _idVlasnikPsa, DateTime _datumPreuzimanja)
            : base(_jmb, _ime, _prezime, _adresa)
        {
            PasDAO p = new PasDAO("localhost", "Centar", "root", "");
            Pas pas = new Pas();
            pas = p.getById(_idVlasnikPsa);

            IdBaza = id;
            vlasnikPsa = pas;
            datumPreuzimanjaPsa = _datumPreuzimanja;
        }


        public override string ToString()
        {
            return "Jmb: " + jmb + ", ime: " + ime + ", prezime: " + prezime + ", vlasnik psa: " + vlasnikPsa;
        }
    }
}