using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Door_to_Door_Sales_App.Repository
{
    public class DoorToDoorRoutes
    {
        public int RouteID { get; set; }
        public string routeName { get; set; }
        public string RouteNotes { get; set; }
    }

    public class Houses
    {
        public int HouseID { get; set; }

        public int RouteID { get; set; }
        public string HouseAddress { get; set; }
        public string HouseNotes { get; set; }
    }
}
