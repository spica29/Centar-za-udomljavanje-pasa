using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Centar
{
    public abstract class Osoba: IDataErrorInfo
    {
        private int _idBaza;

        public int IdBaza
        {
            get { return _idBaza; }
            set { _idBaza = value; }
        }


        private String _jmb;
        public String jmb
        {
            get
            {
                return _jmb;
            }
            set
            {
               _jmb = value;
            }
        }
 
        private String _ime;
 
        public String ime
        {
            get { return _ime; }
            set
            {
                _ime = value;
            }
        }
 
        public String _prezime;
        public String prezime
        {
            get { return _prezime; }
            set
            {
                _prezime = value;
            }
        }
 
        private String _adresa;

        public String adresa
        {
            get { return _adresa; }
            set
            {
                _adresa = value;
            }
        }

        public Osoba()
        {
        }

        
        public Osoba(string _jmb, string _ime, string _prezime, string _adresa)
        {
            jmb = _jmb;
            ime = _ime;
            prezime = _prezime;
            adresa = _adresa;
        }

        public string Error
        {
            get { return null; }
        }

        public virtual string this[string put] 
        {
            get 
            {
                string rezultat = null;

                if (put == "jmb")
                {
                    if (this.jmb.Length != 13)
                        rezultat = "JMB mora imati 13 karaktera";

                }
                if (put == "ime")
                {
                    if (this.ime.Length <= 3)
                        rezultat = "Ime mora imati vise od 3 karaktera";
                }

                if (put == "prezime")
                {
                    if (this.prezime.Length <= 3)
                        rezultat = "Prezime mora imati vise od 3 karaktera";

                }
                if (put == "adresa")
                {
                    if (this.adresa.Length <= 5)
                        rezultat = "Adresa mora imati vise od 5 karaktera";

                }

                return rezultat;
            
            }
        }
        public override string ToString()
        {
            return "JMB: " + jmb + ", IME: " + ime + ", PREZIME: " + prezime+ ", ADRESA: "+adresa;
        }
    }
}
