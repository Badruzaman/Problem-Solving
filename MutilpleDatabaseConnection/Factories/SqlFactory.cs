using MutilpleDatabaseConnection.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MutilpleDatabaseConnection.Factories
{
    public class SqlFactory : IDataSourceFactory
    {
        public IDataSourceConnection CreateConnection()
        {
            return new SqlConnection();
        }
    }
}
