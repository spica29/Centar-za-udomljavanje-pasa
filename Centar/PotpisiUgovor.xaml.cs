using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Centar
{
    /// <summary>
    /// Interaction logic for PotpisiUgovor.xaml
    /// </summary>
    public partial class PotpisiUgovor : Window
    {
        public PotpisiUgovor()
        {
            InitializeComponent();
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
                listbox_psi.Items.Clear();
                listbox_radnici.Items.Clear();
                listbox_klijenti.Items.Clear();

                //ucitavanje neudomljenih pasa
                PasDAO pd = new PasDAO("localhost", "Centar", "root", "");
                List<Pas> psi = new List<Pas>();
                psi = pd.getAllNeudomljene();
                foreach (Pas p in psi)
                {
                    listbox_psi.Items.Add(p);
                }

                //ucitavanje klijenata
                KlijentDAO kd = new KlijentDAO("localhost", "Centar", "root", "");
                List<Klijent> klijenti = new List<Klijent>();
                klijenti = kd.getAll();
                foreach (Klijent p in klijenti)
                {
                    listbox_klijenti.Items.Add(p);
                }

                //ucitavanje radnika
                RadnikDAO rd = new RadnikDAO("localhost", "Centar", "root", "");
                List<Radnik> radnici = new List<Radnik>();
                radnici = rd.getAll();
                foreach (Radnik p in radnici)
                {
                    listbox_radnici.Items.Add(p);
                }
            }
            catch (Exception izuz)
            {
                System.Windows.Forms.MessageBox.Show(izuz.Message);
            }
        }

        private void button_cancel_Click(object sender, RoutedEventArgs e)
        {
            Ugovor_Opcije u = new Ugovor_Opcije();
            u.Show();
            this.Close();
        }

        private void button_potpisi_Click(object sender, RoutedEventArgs e)
        {
            try 
	        {	        
		        Random r=new Random();
                petlja:
                int sif=r.Next(100000,999999);
                
                UgovorDAO ugovorD1 = new UgovorDAO("localhost", "Centar", "root", "");
                Ugovor Ugovor = new Ugovor();
                Ugovor = ugovorD1.getById(sif);
                if (Ugovor.Sifra==sif)
                {
                    goto petlja; 
                }
                    
                UgovorDAO ugovorD = new UgovorDAO("localhost", "Centar", "root", "");
                Ugovor ugovorNovi = new Ugovor(sif,((Pas)listbox_psi.SelectedItem),((Klijent)listbox_klijenti.SelectedItem),((Radnik)listbox_radnici.SelectedItem));
                ugovorD.create(ugovorNovi);

                //update psa... stanje u udomljen
                Pas p= new Pas();
                p = (Pas)listbox_psi.SelectedItem;
                p.status = "Udomljen";
                PasDAO pasKonekcija = new PasDAO("localhost", "Centar", "root", "");
                pasKonekcija.update(p);

                System.Windows.Forms.MessageBox.Show("Novi ugovor je zakljucen","Obavjestenje");
	        }
	        catch (Exception izuz)
	        {
		        System.Windows.Forms.MessageBox.Show(izuz.Message);
	        }
            Ugovor_Opcije ug = new Ugovor_Opcije();
            ug.Show();
            this.Close();
            
        }
    }
}
