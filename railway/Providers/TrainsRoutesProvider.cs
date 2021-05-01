using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using RailWay.Common;
using RailWay.Providers;
using RailWay.Validator;



namespace RailWay.Providers
{
    static class TrainsRoutesProvider
    {
        public static TrainTime_table Read(string stationDistancesPath, string trainsRoutesPath)
        {
            StationRoutes stationRoutes = StationDistancesProvider.Read(stationDistancesPath);
            TrainTime_table trainTime_Table = new TrainTime_table();
            List<string> lines = CommonProvider.Read(trainsRoutesPath);
            foreach (string line in lines)
            {
                Train new_train = new Train();
                int[] nums = Array.ConvertAll(line.Split(new char[] { ' ' }), int.Parse);
                Train train = new Train();
                for (int i = 0; i < nums.Length - 1; i++)
                {
                    Route route = new Route(nums[i], nums[i + 1], stationRoutes.FindLengthOfRoute(nums[i], nums[i + 1]));
                    for (int j = 0; j < stationRoutes.FindLengthOfRoute(nums[i], nums[i + 1]); j++)
                    {
                        train.AddRoute(route);
                    }
                }
                trainTime_Table.AddTrainToAllTrains(train);
            }
            return trainTime_Table;
        }
    }
}
