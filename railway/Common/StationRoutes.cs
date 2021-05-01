using System;
using System.Collections.Generic;
using System.Text;
using RailWay.Common;
using RailWay.Providers;
using RailWay.Validator;

namespace RailWay.Common
{
    class StationRoutes
    {
        private List<Route> allPosibleRoutes;

        public StationRoutes()
        {           
            allPosibleRoutes = new List<Route>();
        }

        public void AddRoute (Route route)
        {
            allPosibleRoutes.Add(route);
        }

        public int FindLengthOfRoute(int dispatchStationNumber, int arivalStationNumber)
        {
            foreach (Route route in allPosibleRoutes)
            {
                if ((dispatchStationNumber == route.DispatchStationNumber) && (arivalStationNumber == route.ArrivalStationNumber)) return route.Length;
            }
            return 0;
        }
    }
}
