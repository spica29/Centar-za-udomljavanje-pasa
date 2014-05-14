using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Centar
{
    public class Pas
    {
        private int id;
        private Image slika;
        private String zdravstvenoStanje;
        private DateTime datumCipiranja;
        private DateTime datumRodjenja;
        private String status;
        private Boolean sterilizovan;
        private DateTime datumSterilizacije;
        private Klijent vlasnik;
        
        public Pas(int idPsa, Image _slika, String zdrStanje, String _status)
        {
            id = idPsa;
            slika = _slika;
            zdravstvenoStanje = zdrStanje;
            status = _status;
        }
        public Pas() { }
        public void PostaviSliku(Image _slika) { slika = _slika; }
        public void PostaviZdravstvenoStanje(String _stanje) { zdravstvenoStanje = _stanje; }
        public void PostaviDatumCipiranja(DateTime _datumCipiranja) { datumCipiranja = _datumCipiranja; }
        public void PostaviStatus(String _status) { status = _status; }
        public void PostaviSterilizaciju(Boolean _sterilizovan) { sterilizovan = _sterilizovan; }
        public void PostaviDatumSterilizacije(DateTime datumSter) { datumSterilizacije = datumSter; }
        public void PostaviVlasnika(Klijent _vlasnik) { vlasnik = _vlasnik; }
        public int DajId() { return id; }
        public Image DajSliku() { return slika; }
        public String DajZdravstvenoStanje() { return zdravstvenoStanje; }
        public DateTime DajDatumCipiranja() { return datumCipiranja; }
        public String DajStatus() { return status; }
        public Boolean DaLiJeSterilizovan() { return sterilizovan; }
        public Klijent DajVlasnika() { return vlasnik; }
        public void IspisiPsa()
        {

        }
    }
}