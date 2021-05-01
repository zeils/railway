using System;
using System.Collections.Generic;
using System.Text;
using RailWay.Common;
using RailWay.Providers;
using RailWay.Validator;
using System.Linq;

namespace RailWay.Common
{
    class TrainTime_table
    {
        private  List<Train> allTrains = new List<Train>();
        public int Count => allTrains.Count;

        public void AddTrainToAllTrains(Train train)
        {
            allTrains.Add(train);
        }

        public int GetMaxNumOfTicks()
        {
            return allTrains.Max(train => train.Count);
        }
       
        public int GetLastTrainStation(int trainNumber, int tick)
        {
            return allTrains[trainNumber].GetLastTrainStation(tick);                                              
        }

        public bool TrainAtStation(int trainNumber, int tick )
        {
            return allTrains[trainNumber].TrainAtStation(tick);
        }
        public bool TwoTrainIntersecting(int firstTrainNumber, int secondTrainNumber, int tick)
        {
            if (this.allTrains[firstTrainNumber].IsIntersecting(this.allTrains[secondTrainNumber],tick)) return true;           
            return false;
        }

        public bool TrainExistAtMoment(int trainNumber, int tick)
        {
            if (allTrains[trainNumber].ExistAtTeak(tick)) return true;
            return false;
        }
    }
}
