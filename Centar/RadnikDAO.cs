using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Centar
{
    public class RadnikDAO : IDaoCrud<Radnik>
    {
        private MySqlConnection con;

        public RadnikDAO(string host, string db, string user, string pass)
        {
            string connectionString = "server=localhost;user=" + user + ";pwd=" + pass + ";database=" + db;
            con = new MySqlConnection(connectionString);
            try
            {
                con.Open();
            }
            catch (Exception e) { throw e; }
        }

        public long create(Radnik entity)
        {
            try
            {
                MySqlCommand c = new MySqlCommand();
                c.CommandText = "insert into radnik values (@id,@jmb,@ime,@prezime,@adresa,@opis_posla,@datum_rodjenja, @username, @password)";
                c.Parameters.AddWithValue("@password", entity.password);
                c.Parameters.AddWithValue("@username", entity.username);
                c.Parameters.AddWithValue("@datum_rodjenja", entity.datumRodjenja);
                c.Parameters.AddWithValue("@opis_posla", entity.opisPosla);
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

        public Radnik read(Radnik entity)
        {
            throw new NotImplementedException();
        }

        public Radnik update(Radnik entity)
        {
            try
            {
                List<Radnik> radnici = new List<Radnik>();
                MySqlCommand c = new MySqlCommand();
                c = new MySqlCommand("select * from Radnik where jmb='" +entity.jmb+ "';", con);
                MySqlDataReader r = c.ExecuteReader();
                while (r.Read())
                    radnici.Add(new Radnik(r.GetString("opis_posla"), r.GetDateTime("datum_rodjenja"), r.GetString("jmb"), r.GetString("ime"), r.GetString("prezime"), r.GetString("adresa"), r.GetString("username"), r.GetString("password")));
                con.Close();
                con.Open();
                if (radnici.Count>0)
                {
                    MySqlCommand ca = new MySqlCommand();
                    ca.CommandText = "update radnik set ime=@ime, prezime=@prezime, adresa=@adresa, opis_posla=@opis_posla, datum_rodjenja=@datum_rodjenja, username=@username, password=@password where jmb=@jmb";
                    ca.Parameters.AddWithValue("@password", entity.password);
                    ca.Parameters.AddWithValue("@username", entity.username);
                    ca.Parameters.AddWithValue("@datum_rodjenja", entity.datumRodjenja);
                    ca.Parameters.AddWithValue("@opis_posla", entity.opisPosla);
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

        public void delete(Radnik entity)
        {
            try
            {
                 MySqlCommand c = new MySqlCommand();
                 c.CommandText = "delete from radnik where jmb=@jmb";
                 c.Parameters.AddWithValue("@jmb", entity.jmb);
                 c.Connection = con;
                 c.Prepare();
                 c.ExecuteNonQuery();
                 con.Close();
            }
            catch (Exception ex)
            {
                
                throw ex;
            }

        }

        public Radnik getById(int id)
        {
            try
            {
                Radnik radnik = new Radnik();
                MySqlCommand c = new MySqlCommand();
                c = new MySqlCommand("select * from radnik where id='" + id.ToString() + "';", con);
                MySqlDataReader r = c.ExecuteReader();
                while (r.Read())
                    radnik = new Radnik(r.GetString("opis_posla"), r.GetDateTime("datum_rodjenja"), r.GetString("jmb"), r.GetString("ime"), r.GetString("prezime"), r.GetString("adresa"), r.GetString("username"), r.GetString("password"));
                con.Close();
                return radnik;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public List<Radnik> getAll()
        {
            try
            {
                List<Radnik> radnici = new List<Radnik>();
                MySqlCommand c = new MySqlCommand();
                c = new MySqlCommand("select * from Radnik;", con);
                MySqlDataReader r = c.ExecuteReader();
                while (r.Read())
                    radnici.Add(new Radnik(r.GetString("opis_posla"), r.GetDateTime("datum_rodjenja"), r.GetString("jmb"), r.GetString("ime"), r.GetString("prezime"), r.GetString("adresa"), r.GetString("username"), r.GetString("password")));
                con.Close();
                return radnici;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public List<Radnik> getByExample(string name, string value)
        {
            try
            {
                List<Radnik> radnici = new List<Radnik>();
                MySqlCommand c = new MySqlCommand();
                c = new MySqlCommand("select * from Radnik where username='" + name + "' and password='" + value + "';", con);
                MySqlDataReader r = c.ExecuteReader();
                while (r.Read())
                    radnici.Add(new Radnik(r.GetString("opis_posla"), r.GetDateTime("datum_rodjenja"), r.GetString("jmb"), r.GetString("ime"), r.GetString("prezime"), r.GetString("adresa"), r.GetString("username"), r.GetString("password")));
                con.Close();
                return radnici;
            }
            catch (Exception e)
            {
                throw e;
            }

        }

        internal List<Radnik> getByExample(string p)
        {
            try
            {
                List<Radnik> radnici = new List<Radnik>();
                MySqlCommand c = new MySqlCommand();
                c = new MySqlCommand("select * from Radnik where jmb='" + p + "';", con);
                MySqlDataReader r = c.ExecuteReader();
                while (r.Read())
                    radnici.Add(new Radnik(r.GetInt32("id"), r.GetString("opis_posla"), r.GetDateTime("datum_rodjenja"), r.GetString("jmb"), r.GetString("ime"), r.GetString("prezime"), r.GetString("adresa"), r.GetString("username"), r.GetString("password")));
                con.Close();
                return radnici;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
