using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Door_to_Door_Sales_App.Repository
{
    public interface IdtdRepository
    {
        List<DoorToDoorRoutes> GetAllRoutes();
        DoorToDoorRoutes GetRouteById(int RouteId);
        void AddRoute(DoorToDoorRoutes route);
        List<Houses> GetRoutesHouses(int RouteID);
        void AddHouse(Houses house);
        Houses GetHouseByID(int HouseID);
    }
}
