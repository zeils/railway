using System;
using RailWay.Common;
using System.IO;

namespace RailWay.Providers
{
    static class StationDistancesProvider
    {           
        public static StationRoutes Read(string stationDistancesPath)
        {          
            StationRoutes newStationRoutes = new StationRoutes();
            string[] lines = File.ReadAllLines(stationDistancesPath);
            foreach (string line in lines)
            {
                int[] nums = Array.ConvertAll(line.Split(new char[] { ' ' }), int.Parse);
                Route firstRoute = new Route(nums[0], nums[1], nums[2]);
                Route secondRoute = new Route(nums[1], nums[0], nums[2]);
                newStationRoutes.AddRoute(firstRoute);
                newStationRoutes.AddRoute(secondRoute);
            }                  
            return newStationRoutes;
        }
    }
}
