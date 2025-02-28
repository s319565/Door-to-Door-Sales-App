using System.IO;
using Door_to_Door_Sales_App.Models;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Odbc;
using System.Windows.Forms;

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
                WHERE RouteID = ?";


                using (var command = new OdbcCommand(query, connection))
                {
                    command.Parameters.AddWithValue("?", RouteID);
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
                            VALUES (?, ?)";

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
        public List<Houses> GetRoutesHouses(int RouteID)
        {
            var Houses = new List<Houses>();

            using (var connection = new OdbcConnection(_connectionString))
            {
                string query = @"SELECT Houses.[HouseID], Houses.[RouteID], Houses.[HouseAddress], Houses.[HouseNotes]
                FROM Houses 
                WHERE RouteID = ?";
                using (var command = new OdbcCommand(query, connection))
                {
                    command.Parameters.AddWithValue("?", RouteID);
                    connection.Open();
                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                if (!reader.IsDBNull(0) && !reader.IsDBNull(1) && !reader.IsDBNull(2) && !reader.IsDBNull(3)) 
                                {
                                    Houses.Add(new Houses
                                    {
                                        HouseID = reader.GetInt32(0),
                                        RouteID = reader.GetInt32(1),
                                        HouseAddress = reader.GetString(2),
                                        HouseNotes = reader.GetString(3),
                                    });
                                }
                            }
                        }
                    }
                }
            }

            return Houses;
        }
        public void AddHouse(Houses house)
        {
            using (var connection = new OdbcConnection(_connectionString))
            {
                string query = @"INSERT INTO Houses
                            (RouteID, HouseAddress, HouseNotes)
                            VALUES (?, ?, ?)";

                /*
                 (@HouseID, @RouteID, @HouseAddress, @HouseNotes)";
                */

                using (var command = new OdbcCommand(query, connection))
                {
                    command.Parameters.Add(new OdbcParameter("@RouteID", OdbcType.Int) { Value = house.RouteID }); //ERROR with RouteID to House Syncapation
                    command.Parameters.Add(new OdbcParameter("@HouseAddress", OdbcType.NVarChar) { Value = house.HouseAddress });
                    command.Parameters.Add(new OdbcParameter("@HouseNotes", OdbcType.NVarChar) { Value = house.HouseNotes });

                    //Open the database connection
                    connection.Open();
                    //Insert the data
                    command.ExecuteNonQuery();
                }
            }
        }

        public Houses GetHouseByID(int HouseID)
        {
            Houses house = null;

            using (var connection = new OdbcConnection(_connectionString))
            {
                string query = @"SELECT HouseID, RouteID, HouseAddress, HouseNotes
                FROM Houses
                WHERE HouseID = ?";

                using (var command = new OdbcCommand(query, connection))
                {
                    command.Parameters.AddWithValue("?", HouseID);
                    connection.Open();
                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            house = new Houses
                            {
                                HouseID = reader.GetInt32(0),
                                RouteID = reader.GetInt32(1),
                                HouseAddress = reader.GetString(2),
                                HouseNotes = reader.GetString(3),
                            };
                        }
                    }
                }
            }

            return house;
        }

        public Transactions GetTransactionbyID(int TransactionID) {
            Transactions transaction = null;

            using (var connection = new OdbcConnection(_connectionString))
            {
                string query = @"SELECT TransactionID, HouseID, ItemName, BoughtStatus, QuantityBought
                FROM Transactions
                WHERE TransactionID = ?";

                using (var command = new OdbcCommand(query, connection))
                {
                    command.Parameters.AddWithValue("?", TransactionID);
                    connection.Open();
                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            transaction = new Transactions
                            {
                                TransactionID = reader.GetInt32(0),
                                HouseID = reader.GetInt32(1),
                                ItemName = reader.GetString(2),
                                BoughtStatus = reader.GetBoolean(3),
                                QuantityBought = reader.GetString(4),
                            };
                        }
                    }
                }
            }

            return transaction;
        }

        public void AddTransaction(Transactions transaction)
        {
            using (var connection = new OdbcConnection(_connectionString))
            {
                string query = @"INSERT INTO Transactions
                            (HouseID, ItemName, BoughtStatus, QuantityBought)
                            VALUES (?, ?, ?, ?)";

                /*
                 (@TransactionID, @HouseID, @Itemname, @BoughtStatus, @QuantityBought)";
                */

                using (var command = new OdbcCommand(query, connection))
                {
                    command.Parameters.Add(new OdbcParameter("@HouseID", OdbcType.Int) { Value = transaction.HouseID }); //ERROR with RouteID to House Syncapation
                    command.Parameters.Add(new OdbcParameter("@ItemName", OdbcType.NVarChar) { Value = transaction.ItemName });
                    command.Parameters.Add(new OdbcParameter("@BoughtStatus", OdbcType.Bit) { Value = transaction.BoughtStatus });
                    command.Parameters.Add(new OdbcParameter("@QuantityBought", OdbcType.NVarChar) { Value = transaction.QuantityBought });

                    //Open the database connection
                    connection.Open();
                    //Insert the data
                    command.ExecuteNonQuery();
                }
            }
        }
        public List<Transactions> GetHousesTransactions(int HouseID)
        {
            var Transactions = new List<Transactions>();

            using (var connection = new OdbcConnection(_connectionString))
            {
                string query = @"SELECT TransactionID, HouseID, ItemName, BoughtStatus, QuantityBought
                FROM Transactions
                WHERE HouseID = ?";
                using (var command = new OdbcCommand(query, connection))
                {
                    command.Parameters.AddWithValue("?", HouseID);
                    connection.Open();
                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                if (!reader.IsDBNull(0) && !reader.IsDBNull(1) && !reader.IsDBNull(2) && !reader.IsDBNull(3) && !reader.IsDBNull(4))
                                {
                                    Transactions.Add(new Transactions
                                    {
                                        TransactionID = reader.GetInt32(0),
                                        HouseID = reader.GetInt32(1),
                                        ItemName = reader.GetString(2),
                                        BoughtStatus = reader.GetBoolean(3),
                                        QuantityBought = reader.GetString(4)
                                    });
                                }
                            }
                        }
                    }
                }
            }

            return Transactions;
        }


    }
}

