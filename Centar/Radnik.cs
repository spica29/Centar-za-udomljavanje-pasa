using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centar
{
    public class Radnik : Osoba
    {
        private String _opisPosla;

        public String opisPosla
        {
            get { return _opisPosla; }
            set { _opisPosla = value; }
        }

        private DateTime _datumRodjenja;

        public DateTime datumRodjenja
        {
            get { return _datumRodjenja; }
            set { _datumRodjenja = value; }
        }

        private String _username;

        public String username
        {
            get { return _username; }
            set { _username = value; }
        }

        private String _password;
        private int p1;
        private string p2;
        private DateTime dateTime;
        private string p3;
        private string p4;
        private string p5;
        private string p6;
        private string p7;
        private string p8;

        public String password
        {
            get { return _password; }
            set { _password = value; }
        }

        public Radnik() { }
        public Radnik(String _opisPosla, DateTime datum, String _jmb, String _ime, String _prezime, String _adresa, string _username, string _password)
            : base(_jmb, _ime, _prezime, _adresa)
        {
            opisPosla = _opisPosla;
            datumRodjenja = datum;
            username = _username;
            password = _password;
        }

        public Radnik(int id, String _opisPosla, DateTime datum, String _jmb, String _ime, String _prezime, String _adresa, string _username, string _password)
            : base(_jmb, _ime, _prezime, _adresa)
        {
            IdBaza = id;
            opisPosla = _opisPosla;
            datumRodjenja = datum;
            username = _username;
            password = _password;
        }


        public override string this[string put]
        {
            get
            {
                string rezultat = null;

                if (put == "opisPosla")
                {
                    if (this.opisPosla.Length <= 3)
                        rezultat = "Opis posla mora imati vise od 3 karaktera";

                }
                else if (put == "username")
                {
                    if (this.username.Length <= 5)
                    {
                        rezultat = "Username mora imati vise od 5 karaktera";
                    }

                }
                else
                {
                    rezultat = base[put];
                }

                return rezultat;
            }
        }
    }
}
