using System.Collections.Generic;
using System.Linq;

namespace RailWay.Common
{
    class TrainTimeTable
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
       
        public int GetLastTrainRoute(int trainNumber, int tick)
        {
            return allTrains[trainNumber].GetLastTrainStation(tick);                                              
        }

        public bool TrainAtStation(int trainNumber, int tick )
        {
            return allTrains[trainNumber].TrainAtStation(tick);
        }
        public bool TwoTrainIntersecting(int firstTrainNumber, int secondTrainNumber, int tick)
        {
            if (this.allTrains[firstTrainNumber].IsIntersecting(this.allTrains[secondTrainNumber], tick)) 
            {           
                return true;
            }
            return false;
        }

        public bool TrainExistAtMoment(int trainNumber, int tick)
        {
            if (allTrains[trainNumber].ExistAtTick(tick))
            {
                return true;
            }
            return false;
        }
    }
}
