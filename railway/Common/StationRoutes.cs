using System.Collections.Generic;


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
                if (route.IsSameRoute(dispatchStationNumber, arivalStationNumber)) return route.Length;
            }
            return 0;
        }       
    }
}
