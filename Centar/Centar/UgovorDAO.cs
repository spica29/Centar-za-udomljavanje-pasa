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
            throw new NotImplementedException();
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
            throw new NotImplementedException();
        }

        public Ugovor getById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Ugovor> getAll()
        {
            throw new NotImplementedException();
        }

        public List<Ugovor> getByExample(string name, string value)
        {
            throw new NotImplementedException();
        }
    }
}
