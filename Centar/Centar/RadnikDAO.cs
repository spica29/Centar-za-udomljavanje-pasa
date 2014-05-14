using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Centar
{
    public class RadnikDAO:IDaoCrud<Radnik>
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
            throw new NotImplementedException();
        }

        public Radnik read(Radnik entity)
        {
            throw new NotImplementedException();
        }

        public Radnik update(Radnik entity)
        {
            throw new NotImplementedException();
        }

        public void delete(Radnik entity)
        {
            throw new NotImplementedException();
        }

        public Radnik getById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Radnik> getAll()
        {
            throw new NotImplementedException();
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
                    radnici.Add(new Radnik(r.GetString("opis_posla"), r.GetDateTime("datum_rodjenja"), r.GetString("jbm"), r.GetString("ime"), r.GetString("prezime"), r.GetString("adresa"),r.GetString("username"), r.GetString("password")));
                return radnici;
            }
            catch (Exception e)
            {
                throw e;
            }
            
        }
    }
}
