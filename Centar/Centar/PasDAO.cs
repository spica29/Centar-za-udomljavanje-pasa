using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

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
            throw new NotImplementedException();
        }

        public Pas read(Pas entity)
        {
            throw new NotImplementedException();
        }

        public Pas update(Pas entity)
        {
            throw new NotImplementedException();
        }

        public void delete(Pas entity)
        {
            throw new NotImplementedException();
        }

        public Pas getById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Pas> getAll()
        {
            throw new NotImplementedException();
        }

        public List<Pas> getByExample(string name, string value)
        {
            throw new NotImplementedException();
        }
    }
}