using System;
using System.Collections.Generic;
using System.Text;
using RailWay.Common;
using RailWay.Providers;
using RailWay.Validator;


namespace RailWay.Common
{
    class Train
    {
        private List<Route> trainRoutes = new List<Route>();
        public int Count => trainRoutes.Count;
        public  void AddRoute(Route route)
        {
            trainRoutes.Add(route);
        }

        public bool TrainAtStation(int tick)
        {
            if (tick == 0) return true;
            if (trainRoutes[tick] != trainRoutes[tick - 1]) return true;
            return false;
        }

        public int GetLastTrainStation(int tick)
        {
            return trainRoutes[tick].DispatchStationNumber;
        }
   
        public bool IsIntersecting(Train train, int tick )
        {
            if (this.trainRoutes[tick].IsIntersecting(train.trainRoutes[tick])) return true;
            return false;           
        }

        public bool ExistAtTeak(int tick)
        {        
            if (tick >= Count) return false;
            return true;       
        }      
    }
}
