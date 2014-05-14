using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Centar
{
    public class KlijentDAO:IDaoCrud<Klijent>
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
            throw new NotImplementedException();
        }

        public Klijent read(Klijent entity)
        {
            throw new NotImplementedException();
        }

        public Klijent update(Klijent entity)
        {
            throw new NotImplementedException();
        }

        public void delete(Klijent entity)
        {
            throw new NotImplementedException();
        }

        public Klijent getById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Klijent> getAll()
        {
            throw new NotImplementedException();
        }

        public List<Klijent> getByExample(string name, string value)
        {
            throw new NotImplementedException();
        }
    }
}
