using MutilpleDatabaseConnection.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MutilpleDatabaseConnection
{
    public class MongoDbConnection : IDataSourceConnection
    {
        public void Connect()
        {
            Console.WriteLine("Mongo db connected");
        }
    }
}
