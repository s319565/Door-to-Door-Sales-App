using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Door_to_Door_Sales_App.Models
{
    public static class DbaseNames
    {
        public static string RouteDBAse { get; } = "SalesAppDatabase.accdb";
        //public static string RouteDBAse { get; } = "SalesAppDatabase.mdb";
        public static string RouteDriver { get; } = "{Microsoft Access Driver (*.mdb, *.accdb)}";

        //var _connectionString = "Driver={SQL Server};Server=your_server_name;Database=your_database_name;Trusted_Connection=yes;";

    }
}
