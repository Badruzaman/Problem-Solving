using MutilpleDatabaseConnection.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MutilpleDatabaseConnection
{
    public class JsonConnection : IDataSourceConnection
    {
        public void Connect()
        {
            Console.WriteLine("Json file connected");
        }
    }
}
