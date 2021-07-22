using System;
using System.Data.SqlClient;
using LinqToDB;
using LinqToDB.Configuration;
using LinqToDB.Data;
using System.Linq;

namespace Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var builder = new LinqToDbConnectionOptionsBuilder();

            builder.UseSqlServer("Server=(Local);Database=Akka;User Id=akkadotnet;Password=q1w2e3r4t5Y^U&I*O(P);");

            var conn = new AppDataConnection(builder.Build());

            //conn.CreateTable<ValidIp>();

            var validIps = conn.GetTable<ValidIp>();

            var q = from x in validIps
                    select x;

            q.First();

            

        }
    }
}
