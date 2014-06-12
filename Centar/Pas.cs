using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace Centar
{
    public class Pas : IDataErrorInfo
    {
        private int _idBaza;

        public int IdBaza
        {
            get { return _idBaza; }
            set { _idBaza = value; }
        }


        private int _id;

        public int id
        {
            get { return _id; }
            set { _id = value; }
        }

        private String _zdravstvenoStanje;

        public String zdravstvenoStanje
        {
            get { return _zdravstvenoStanje; }
            set { _zdravstvenoStanje = value; }
        }

        private DateTime _datumCipiranja;

        public DateTime datumCipiranja
        {
            get { return _datumCipiranja; }
            set { _datumCipiranja = value; }
        }

        private DateTime _datumRodjenja;

        public DateTime datumRodjenja
        {
            get { return _datumRodjenja; }
            set { _datumRodjenja = value; }
        }

        private String _status;

        public String status
        {
            get { return _status; }
            set { _status = value; }
        }

        private Boolean _sterilizovan;

        public Boolean sterilizovan
        {
            get { return _sterilizovan; }
            set { _sterilizovan = value; }
        }

        private DateTime _datumSterilizacije;
        
        public DateTime datumSterilizacije
        {
            get { return _datumSterilizacije; }
            set { _datumSterilizacije = value; }
        }

        public Pas(int idPsa, String zdrStanje, String _status)
        {
            id = idPsa;
            zdravstvenoStanje = zdrStanje;
            status = _status;
        }

        public Pas(int idPsa, String zdrStanje, String _status, DateTime _datumRodjenja, DateTime _datumCipiranja, bool _sterilizovan, DateTime _datumSterilizacije)
        {
            id = idPsa;
            zdravstvenoStanje = zdrStanje;
            status = _status;
            datumRodjenja = _datumRodjenja;
            datumCipiranja = _datumCipiranja;
            sterilizovan = _sterilizovan;
            datumSterilizacije = _datumSterilizacije;
        }
        public Pas() { }

        public Pas(int _idBaza, int idPsa, string p3, string zdrStanje, DateTime _datumRodjenja, DateTime _datumCipiranja, bool _sterilizovan, DateTime _datumSterilizacije)
        {
            IdBaza = _idBaza;
            id = idPsa;
            zdravstvenoStanje = zdrStanje;
            status = _status;
            datumRodjenja = _datumRodjenja;
            datumCipiranja = _datumCipiranja;
            sterilizovan = _sterilizovan;
            datumSterilizacije = _datumSterilizacije;
        }

        public void IspisiPsa()
        {

        }

        public string Error
        {
            get { return null; }
        }

        public string this[string put]
        {
            get 
            {
                string rezultat = null;

                if (put == "status")
                {
                    if (this.status == null)
                        rezultat = "Izaberi status";
/*
                    //ako je udomljen a nije oznacen vlasnik
                    else if (this.status.ToLower() == "udomljen")
                    {
                        if (this.vlasnik == null)
                        {
                            rezultat = "Izaberi vlasnika";
                        }
                    }*/
                }

                if (put == "zdravstvenoStanje")
                {
                    if (this.zdravstvenoStanje == null)
                        rezultat = "Upisi zdravstveno stanje";
                }

                if (put=="id")
                {
                    //treba ubaciti neki uslov
                    if (this.id.ToString()==null)
                    {

                        rezultat = "NESTO";    
                    }

                }
                

                return rezultat;
            
            }
        }

        public override string ToString()
        {
            return "Id: " + id + ", zdravstveno stanje: " + zdravstvenoStanje + ", status: " + status;
        }
    }
}