using MutilpleDatabaseConnection.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MutilpleDatabaseConnection
{
    public class SqlConnection : IDataSourceConnection
    {
        public void Connect()
        {
            Console.WriteLine("Sql connected");
        }
    }
}
