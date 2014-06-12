using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows;

namespace Centar
{
    public class KlijentDAO : IDaoCrud<Klijent>
    {
        private MySqlConnection con;

        public KlijentDAO(string host, string db, string user, string pass)
        {
            string connectionString = "server=localhost;user=" + user + ";pwd=" + pass + ";database=" + db;
            con = new MySqlConnection(connectionString);
            try
            {
                con.Open();
            }
            catch (Exception e) { throw e; }
        }

        public long create(Klijent entity)
        {
            try
            {
                MySqlCommand c = new MySqlCommand();
                c.CommandText = "insert into klijent values (@id,@jmb,@ime,@prezime,@adresa,@datum_preuzimanja_psa,@Pas_id)";
                c.Parameters.AddWithValue("@Pas_id", entity.vlasnikPsa.IdBaza);
                c.Parameters.AddWithValue("@datum_preuzimanja_psa", entity.datumPreuzimanjaPsa);
                c.Parameters.AddWithValue("@adresa", entity.adresa);
                c.Parameters.AddWithValue("@prezime", entity.prezime);
                c.Parameters.AddWithValue("@ime", entity.ime);
                c.Parameters.AddWithValue("@jmb", entity.jmb);
                c.Parameters.AddWithValue("id", null);
                c.Connection = con;
                c.Prepare();
                c.ExecuteNonQuery();
                con.Close();
                return 1;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public Klijent read(Klijent entity)
        {
            throw new NotImplementedException();
        }

        public Klijent update(Klijent entity)
        {
            try
            {
                List<Klijent> klijenti = new List<Klijent>();
                MySqlCommand c = new MySqlCommand();
                c = new MySqlCommand("select * from klijent;", con);
                MySqlDataReader r = c.ExecuteReader();
                while (r.Read())
                    klijenti.Add(new Klijent(r.GetString("jmb"), r.GetString("ime"), r.GetString("prezime"), r.GetString("adresa"), r.GetInt32("Pas_id"), r.GetDateTime("datum_preuzimanja_psa")));
                con.Close();
                con.Open();
                if (klijenti.Count > 0)
                {
                    MySqlCommand ca = new MySqlCommand();
                    ca.CommandText = "update klijent set ime=@ime, prezime=@prezime, adresa=@adresa, Pas_id=@Pas_id, datum_preuzimanja_psa=@datum_preuzimanja_psa where jmb=@jmb;";
                    ca.Parameters.AddWithValue("@datum_preuzimanja_psa", entity.datumPreuzimanjaPsa);
                    ca.Parameters.AddWithValue("@Pas_id", entity.vlasnikPsa.IdBaza);
                    ca.Parameters.AddWithValue("@adresa", entity.adresa);
                    ca.Parameters.AddWithValue("@prezime", entity.prezime);
                    ca.Parameters.AddWithValue("@ime", entity.ime);
                    ca.Parameters.AddWithValue("@jmb", entity.jmb);
                    ca.Parameters.AddWithValue("id", null);
                    ca.Connection = con;
                    ca.Prepare();
                    ca.ExecuteNonQuery();
                    con.Close();
                }
                return entity;
            }
            catch (Exception e)
            {

                throw e;
            }
        }

        public void delete(Klijent entity)
        {
            throw new NotImplementedException();
        }

        public Klijent getById(int id)
        {
            try
            {
                Klijent klijent = new Klijent();
                MySqlCommand c = new MySqlCommand();
                c = new MySqlCommand("select * from klijent where id='"+ id.ToString() + "';", con);
                MySqlDataReader r = c.ExecuteReader();
                while (r.Read())
                    klijent=new Klijent(r.GetString("jmb"), r.GetString("ime"), r.GetString("prezime"), r.GetString("adresa"), r.GetInt32("Pas_id"), r.GetDateTime("datum_preuzimanja_psa"));
                con.Close();
                return klijent;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public List<Klijent> getAll()
        {
            try
            {               
                List<Klijent> klijenti = new List<Klijent>();
                MySqlCommand c = new MySqlCommand();
                c = new MySqlCommand("select * from klijent;", con);
                MySqlDataReader r = c.ExecuteReader();
                while (r.Read())
                    klijenti.Add(new Klijent(r.GetString("jmb"), r.GetString("ime"), r.GetString("prezime"), r.GetString("adresa"), r.GetInt32("Pas_id"), r.GetDateTime("datum_preuzimanja_psa")));
                con.Close();
                return klijenti;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Klijent> getByExample(string name, string value)
        {
            throw new NotImplementedException();
        }

        internal List<Klijent> getByExample(string p)
        {
            List<Klijent> klijenti = new List<Klijent>();
            MySqlCommand c = new MySqlCommand();
            c = new MySqlCommand("select * from klijent where jmb='" + p + "';", con);
            MySqlDataReader r = c.ExecuteReader();
            while (r.Read())
                klijenti.Add(new Klijent(r.GetInt32("id"),r.GetString("jmb"), r.GetString("ime"), r.GetString("prezime"), r.GetString("adresa"), r.GetInt32("Pas_id"), r.GetDateTime("datum_preuzimanja_psa")));
            con.Close();
            return klijenti;
        }
    }
}
