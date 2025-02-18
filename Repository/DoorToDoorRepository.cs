using System.IO;
using Door_to_Door_Sales_App.Models;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Odbc;

namespace Door_to_Door_Sales_App.Repository
{

    public class DoorToDoorRepository : IdtdRepository
    {
        private readonly string _connectionString;

    public DoorToDoorRepository()
    {
        //Gets and Builds the Application Path of the applicatino location
        string basePath = CurrentPath.GetDbasePath() + "\\";
        //Gets name of the database
        string dbName = DbaseNames.RouteDBAse;
        //Combines the Path with the Database
        string path = Path.Combine(basePath, dbName); // Safely combines paths

        //Gets the Connection String from the App.Config file
        string dbase = ConfigurationManager.ConnectionStrings["AccessDbODBC"].ConnectionString;

        //Replaces {0} and {1} with correct values
        string cs = string.Format(dbase, DbaseNames.RouteDriver, path);

        //Connection String we will use
        _connectionString = cs;
    }

    public List<DoorToDoorRoutes> GetAllRoutes()
    {
        var Routes = new List<DoorToDoorRoutes>();

        using (var connection = new OdbcConnection(_connectionString))
        {
                string query = @"SELECT RouteID, routeName, RouteNotes
                                 FROM Routes";
                                 //WHERE RouteID = @RouteID";

            using (var command = new OdbcCommand(query, connection))
            {
                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            if (!reader.IsDBNull(0) && !reader.IsDBNull(1) && !reader.IsDBNull(2))
                            {
                                Routes.Add(new DoorToDoorRoutes
                                {
                                    RouteID = reader.GetInt32(0),
                                    routeName = reader.GetString(1),
                                    RouteNotes = reader.GetString(2),
                                });
                            }
                        }
                    }
                }
            }
        }

        return Routes;
    }

    public DoorToDoorRoutes GetRouteById(int RouteID)
    {
        DoorToDoorRoutes route = null;

        using (var connection = new OdbcConnection(_connectionString))
        {
            string query = @"SELECT RouteID, routeName, RouteNotes
                FROM Routes
                WHERE RouteID = @RouteID";


            using (var command = new OdbcCommand(query, connection))
            {
                command.Parameters.AddWithValue("@RouteID", RouteID);
                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        route = new DoorToDoorRoutes
                        {
                            RouteID = reader.GetInt32(0),
                            routeName = reader.GetString(1),
                            RouteNotes = reader.GetString(2),
                        };
                    }
                }
            }
        }

        return route;
    }

    public void AddRoute(DoorToDoorRoutes route)
    {
        using (var connection = new OdbcConnection(_connectionString))
        {
            string query = @"INSERT INTO Routes
                            (routeName, RouteNotes)
                            VALUES (?, ?, ?)";
                                     
            /*
             (@RouteID, @routeName, @RouteNotes)";
            */

            using (var command = new OdbcCommand(query, connection))
            {
                command.Parameters.Add(new OdbcParameter("@routeName", OdbcType.NVarChar) { Value = route.routeName });
                command.Parameters.Add(new OdbcParameter("@RouteNotes", OdbcType.NVarChar) { Value = route.RouteNotes });

                //Open the database connection
                connection.Open();
                //Insert the data
                command.ExecuteNonQuery();
            }
        }
    }
}
        
}

