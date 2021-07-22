namespace Console
{
    using LinqToDB;
    using LinqToDB.Configuration;
    using LinqToDB.Data;

    public class AppDataConnection : DataConnection
    {
        public ITable<ValidIp> ValidIps => GetTable<ValidIp>();

        public AppDataConnection(LinqToDbConnectionOptions options) : base(options)
        {
        }
    }
}
