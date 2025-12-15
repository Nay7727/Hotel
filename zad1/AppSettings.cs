using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelSystem
{
    public static class AppSettings
    {
        public static string Server = "localhost";
        public static string Database = "HotelDbContext";
        public static string User = "root";
        public static string Password = "root";

        public static string ConnectionString =>
            $"Server={Server};Database={Database};User={User};Password={Password};";
    }
}

