
using MutilpleDatabaseConnection.Contracts;
using MutilpleDatabaseConnection.Factories;

IDataSourceFactory sqlFactory = new SqlFactory();
IDataSourceConnection sqlConnection = sqlFactory.CreateConnection();
sqlConnection.Connect();

Console.ReadKey();
