using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centar
{
    public class UgovorDAO:IDaoCrud<Ugovor>
    {
        private MySqlConnection con;

        public UgovorDAO(string host, string db, string user, string pass)
        {
            string connectionString = "server=localhost;user=" + user + ";pwd=" + pass + ";database=" + db;
            con = new MySqlConnection(connectionString);
            try
            {
                con.Open();
            }
            catch (Exception e) { throw e; }
        }


        public long create(Ugovor entity)
        {
            try
            {
                MySqlCommand c = new MySqlCommand();
                c.CommandText = "insert into ugovor values (@id,@id_ugovora,@Radnik_id,@Pas_id,@Klijent_id)";
                c.Parameters.AddWithValue("@Klijent_id", entity.Vlasnik.IdBaza);
                c.Parameters.AddWithValue("@Pas_id", entity.Pas.IdBaza);
                c.Parameters.AddWithValue("@Radnik_id", entity.Radnik.IdBaza);
                c.Parameters.AddWithValue("@id_ugovora", entity.Sifra);
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

        public Ugovor read(Ugovor entity)
        {
            throw new NotImplementedException();
        }

        public Ugovor update(Ugovor entity)
        {
            throw new NotImplementedException();
        }

        public void delete(Ugovor entity)
        {
            try
            {
                MySqlCommand c = new MySqlCommand();
                c.CommandText = "delete from ugovor where id_ugovora=@id_ugovora";
                c.Parameters.AddWithValue("@id_ugovora", entity.Sifra);
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

        public Ugovor getById(int id)
        {
            try
            {
                Ugovor ug = new Ugovor();
                MySqlCommand c = new MySqlCommand();
                c = new MySqlCommand("select * from ugovor where id='" + id.ToString() + "';", con);
                MySqlDataReader r = c.ExecuteReader();
                while (r.Read())
                    ug = new Ugovor(r.GetInt32("id_ugovora"), r.GetInt32("Pas_id"), r.GetInt32("Klijent_id"), r.GetInt32("Radnik_id"));
                con.Close();
                return ug;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Ugovor> getAll()
        {
            try
            {
                List<Ugovor> ugovori = new List<Ugovor>();
                MySqlCommand c = new MySqlCommand();
                c = new MySqlCommand("select * from ugovor;", con);
                MySqlDataReader r = c.ExecuteReader();
                while (r.Read())
                    ugovori.Add(new Ugovor(r.GetInt32("id_ugovora"), r.GetInt32("Pas_id"), r.GetInt32("Klijent_id"), r.GetInt32("Radnik_id")));
                con.Close();
                return ugovori;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public List<Ugovor> getByExample(string name, string value)
        {
            throw new NotImplementedException();
        }
    }
}
