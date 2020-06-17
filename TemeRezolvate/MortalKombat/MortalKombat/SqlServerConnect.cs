using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MortalKombat
{
    public class SqlServerConnect : DbConnect
    {
        public SqlServerConnect(string connectionString): base(connectionString)
        {

        }

        public SqlServerConnect(string server, string dataBase, string user, string password) : base(server, dataBase, user, password)
        {

        }

        public override void Close()
        {
            Console.WriteLine("Am inchis conexiunea.");
        }

        public override bool Open()
        {
            Console.WriteLine("Am deschis conexiunea.");
            return true;
        }
    }
}
