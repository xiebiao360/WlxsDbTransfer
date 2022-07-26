using MySql.Data.MySqlClient;
using System;

namespace WlxsDbTransfer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var connectionString = "server=127.0.0.1;uid=root;pwd=xie360360;database=wlxs_copy";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                // Do work here.  
            }
            Console.WriteLine("Hello World!");
        }
    }
}
