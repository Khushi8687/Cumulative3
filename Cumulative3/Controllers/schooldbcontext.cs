using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MySql.Data.MySqlClient;


namespace Cumulative3.Controllers
{
    public class schooldbcontext : Controller
    {
        private static string User { get { return "root"; } }
        private static string Password { get { return ""; } }
        private static string Database { get { return "blog"; } }
        private static string Server { get { return "localhost"; } }
        private static string Port { get { return "80"; } }

        protected static string ConnectionString
        {
            get
            {
                return "server=" + Server
                    + ";user=" + User
                    + ";database=" + Database
                    + ";port=" + Port
                    + ";password=" + Password
                    + ";convert zero datetime=True";
            }
        }

        public MySqlConnection AccessDatabase()
        {
            return new MySqlConnection(ConnectionString);
        }
    }
}