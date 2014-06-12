using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows;
using System.IO;
using System.Data.SqlClient;
using System.ComponentModel;
using System.Windows.Controls;
using System.Drawing;
using System.Windows.Media.Imaging;
using System.Windows.Interop;
using System.Data;
using System.Windows.Forms;

namespace Centar
{
    public class PasDAO : IDaoCrud<Pas>
    {
        private MySqlConnection con;

        public PasDAO(string host, string db, string user, string pass)
        {
            string connectionString = "server=localhost;user=" + user + ";pwd=" + pass + ";database=" + db;
            con = new MySqlConnection(connectionString);
            try
            {
                con.Open();
            }
            catch (Exception e) { throw e; }
        }

        public long create(Pas entity)
        {
            try
            {
                MySqlCommand c = new MySqlCommand();
                c.CommandText = "insert into pas values (@id,@id_psa,@zdravstveno_stanje,@datum_cipiranja,@datumm_rodjenja,@status,@sterilizovan, @datum_sterilizacije)";
                c.Parameters.AddWithValue("@datum_sterilizacije", entity.datumSterilizacije);
                c.Parameters.AddWithValue("@sterilizovan", entity.sterilizovan);
                c.Parameters.AddWithValue("@status", entity.status);
                c.Parameters.AddWithValue("@datumm_rodjenja", entity.datumRodjenja);
                c.Parameters.AddWithValue("@datum_cipiranja", entity.datumCipiranja);
                c.Parameters.AddWithValue("@zdravstveno_stanje", entity.zdravstvenoStanje);
                c.Parameters.AddWithValue("@id_psa", entity.id);
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

        public Pas read(Pas entity)
        {
            throw new NotImplementedException();
        }

        public Pas update(Pas entity)
        {
            try
            {
                List<Pas> psi = new List<Pas>();
                MySqlCommand c = new MySqlCommand();
                c = new MySqlCommand("select * from pas;", con);
                MySqlDataReader r = c.ExecuteReader(); 
                while (r.Read())
                    psi.Add(new Pas(r.GetInt32("id_psa"), r.GetString("zdravstveno_stanje"), r.GetString("status"), r.GetDateTime("datumm_rodjenja"), r.GetDateTime("datum_cipiranja"), r.GetBoolean("sterilizovan"), r.GetDateTime("datum_sterilizacije")));
                con.Close();
                con.Open();
                if (psi.Count > 0)
                {
                    MySqlCommand ca = new MySqlCommand();
                    ca.CommandText = "update pas set zdravstveno_stanje=@zdravstveno_stanje, datum_cipiranja=@datum_cipiranja, datumm_rodjenja=@datumm_rodjenja, status=@status, sterilizovan=@sterilizovan, datum_sterilizacije=@datum_sterilizacije where id_psa=@id_psa";
                    ca.Parameters.AddWithValue("@datum_sterilizacije", entity.datumSterilizacije);
                    ca.Parameters.AddWithValue("@sterilizovan", entity.sterilizovan);
                    ca.Parameters.AddWithValue("@status", entity.status);
                    ca.Parameters.AddWithValue("@datumm_rodjenja", entity.datumRodjenja);
                    ca.Parameters.AddWithValue("@datum_cipiranja", entity.datumCipiranja);
                    ca.Parameters.AddWithValue("@zdravstveno_stanje", entity.zdravstvenoStanje);
                    ca.Parameters.AddWithValue("@id_psa", entity.id);
                    //ca.Parameters.AddWithValue("id", null); 
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

        public void delete(Pas entity)
        {
            try
            {
                MySqlCommand c = new MySqlCommand();
                c.CommandText = "delete from pas where id_psa=@id_psa";
                c.Parameters.AddWithValue("@id_psa", entity.id);
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

        public Pas getById(int id)
        {
            try
            {
                Pas pas = new Pas();
                MySqlCommand c = new MySqlCommand();
                c = new MySqlCommand("select * from pas where id='" + id.ToString() + "';", con);
                MySqlDataReader r = c.ExecuteReader();
                while (r.Read())
                    pas=new Pas(r.GetInt32("id_psa"), r.GetString("zdravstveno_stanje"), r.GetString("status"), r.GetDateTime("datumm_rodjenja"), r.GetDateTime("datum_cipiranja"), r.GetBoolean("sterilizovan"), r.GetDateTime("datum_sterilizacije"));
                con.Close();
                return pas;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public List<Pas> getAll()
        {
            try
            {
                List<Pas> psi = new List<Pas>();
                MySqlCommand c = new MySqlCommand();
                c = new MySqlCommand("select * from pas;", con);
                MySqlDataReader r = c.ExecuteReader();
                while (r.Read())
                    psi.Add(new Pas(r.GetInt32("id_psa"), r.GetString("zdravstveno_stanje"), r.GetString("status"), r.GetDateTime("datumm_rodjenja"), r.GetDateTime("datum_cipiranja"), r.GetBoolean("sterilizovan"), r.GetDateTime("datum_sterilizacije")));
                con.Close();
                return psi;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public List<Pas> getAllNeudomljene()
        {
            try
            {
                List<Pas> psi = new List<Pas>();
                MySqlCommand c = new MySqlCommand();
                c = new MySqlCommand("select * from pas where status='Ceka udomljavanje' and status != 'bolestan';", con);
                MySqlDataReader r = c.ExecuteReader();
                while (r.Read())
                    psi.Add(new Pas(r.GetInt32("id_psa"), r.GetString("zdravstveno_stanje"), r.GetString("status"), r.GetDateTime("datumm_rodjenja"), r.GetDateTime("datum_cipiranja"), r.GetBoolean("sterilizovan"), r.GetDateTime("datum_sterilizacije")));
                con.Close();
                return psi;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public List<Pas> getAllUdomljeneINeudomljene()
        {
            try
            {
                List<Pas> psi = new List<Pas>();
                MySqlCommand c = new MySqlCommand();
                c = new MySqlCommand("select * from pas where status='Udomljen' or status='Ceka udomljavanje';", con);
                MySqlDataReader r = c.ExecuteReader();
                while (r.Read())
                    psi.Add(new Pas(r.GetInt32("id_psa"), r.GetString("zdravstveno_stanje"), r.GetString("status"), r.GetDateTime("datumm_rodjenja"), r.GetDateTime("datum_cipiranja"), r.GetBoolean("sterilizovan"), r.GetDateTime("datum_sterilizacije")));
                con.Close();
                return psi;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public List<Pas> getByExample(string name, string value)
        {
            throw new NotImplementedException();
        }


        internal List<Pas> getByExample(string p)
        {
            try
            {
                List<Pas> psi = new List<Pas>();
                MySqlCommand c = new MySqlCommand();
                c = new MySqlCommand("select * from pas where id_psa='" + p + "';", con);
                MySqlDataReader r = c.ExecuteReader();
                while (r.Read())
                    psi.Add(new Pas(r.GetInt32("id"), r.GetInt32("id_psa"), r.GetString("zdravstveno_stanje"), r.GetString("status"), r.GetDateTime("datumm_rodjenja"), r.GetDateTime("datum_cipiranja"), r.GetBoolean("sterilizovan"), r.GetDateTime("datum_sterilizacije")));
                con.Close();
                return psi;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}