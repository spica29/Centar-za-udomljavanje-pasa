using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centar
{
    public class Radnik : Osoba
    {
		private String opisPosla;
		private DateTime datumRodjenja;
		private string username;
        private string password;

        public Radnik(){ }
        public Radnik(String _opisPosla, DateTime datum, String _jmb, String _ime, String _prezime, String _adresa,string _username, string _password)
        : base(_jmb, _ime, _prezime, _adresa)
        {
            opisPosla = _opisPosla;
            datumRodjenja = datum;
            username = _username;
            password = _password;
        }

        public override string dajIme()
        {
            return base.dajIme();
        }
    }
}
