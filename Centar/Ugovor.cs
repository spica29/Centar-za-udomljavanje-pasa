using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Centar
{

    public class Ugovor
    {

        private int _IdBaza;

        public int IdBaza
        {
            get { return _IdBaza; }
            set { _IdBaza = value; }
        }
        

        private int _sifra;

        public int Sifra
        {
            get { return _sifra; }
            set { _sifra = value; }
        }

        private Pas _pas;

        public Pas Pas
        {
            get { return _pas; }
            set { _pas = value; }
        }

        private Klijent _vlasnik;

        public Klijent Vlasnik
        {
            get { return _vlasnik; }
            set { _vlasnik = value; }
        }

        private Radnik _radnik;
       
        public Radnik Radnik
        {
            get { return _radnik; }
            set { _radnik = value; }
        }


        public Ugovor()
        {

        }
        
        public Ugovor(int sifra, Pas pasPr, Klijent klijentPr, Radnik radnikPr)
        {
            PasDAO p = new PasDAO("localhost", "Centar", "root", "");
            List<Pas> pas = new List<Pas>();
            pas = p.getByExample(Convert.ToString(pasPr.id));

            KlijentDAO k = new KlijentDAO("localhost", "Centar", "root", "");
            List<Klijent> klij = new List<Klijent>();
            klij = k.getByExample(klijentPr.jmb);

            RadnikDAO r = new RadnikDAO("localhost", "Centar", "root", "");
            List<Radnik> rad = new List<Radnik>();
            rad = r.getByExample(radnikPr.jmb);

            Sifra = sifra;
            Pas = pas[0];
            Vlasnik = klij[0];
            Radnik = rad[0];
        }

        public Ugovor(int sifra, int idPas, int idKlijent, int idRadnik)
        {
            PasDAO p = new PasDAO("localhost", "Centar", "root", "");
            Pas pas = new Pas();
            pas = p.getById(idPas);

            KlijentDAO k = new KlijentDAO("localhost", "Centar", "root", "");
            Klijent klij = new Klijent();
            klij = k.getById(idKlijent);

            RadnikDAO r = new RadnikDAO("localhost", "Centar", "root", "");
            Radnik rad = new Radnik();
            rad = r.getById(idRadnik);

            Sifra = sifra;
            Pas = pas;
            Vlasnik = klij;
            Radnik = rad;
        }

        public override string ToString()
        {
            return "Sifra: "+Sifra+", Pas: "+Pas+", Vlasnik: "+Vlasnik+", Radnik: "+Radnik;
        }
    }
}