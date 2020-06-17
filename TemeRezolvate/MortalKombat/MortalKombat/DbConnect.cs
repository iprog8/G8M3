using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MortalKombat
{
    public abstract class DbConnect
    {
        public DbConnect(string connectionString)
        {
            ConnectionString = connectionString;
        }

        public DbConnect(string server, string dataBase, string user, string password)
        {
            ConnectionString = $"Server = {server}; Data base = {dataBase}; UserName = {user}; Password = {password};";
        }

        public string ConnectionString { get; private set; }

        public abstract bool Open();
        public abstract void Close();
    }
}
