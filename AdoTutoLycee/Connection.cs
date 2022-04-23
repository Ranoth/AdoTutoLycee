using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Text;

namespace AdoTutoLycee
{
    internal class Connection
    {
        private static string connectionSring = "server=serverbtssiojv.ddns.net;port=3306;uid=buhot;pwd=buhot;database=buhot_csharp";
        //private static string connectionSring = "server=localhost;port=3306;uid=root;pwd=root;database=buhot_csharp";
        private static MySqlConnection maConnection = new MySqlConnection(connectionSring);

        public static MySqlConnection MaConnection { get => maConnection; }
    }
}
