using System;
using System.Collections.Generic;
using System.Text;

namespace railway.include
{
    class TrainTime_table
    {
        private  List<Train> AllTrainsTime_table = new List<Train>();

   
        public void AddTrainToTime_table(Train train)
        {
            AllTrainsTime_table.Add(train);
        }

        public  int GetMaximumTimeOfTrainTransition()
        {

            int maxTime = 0;
            foreach (Train train in AllTrainsTime_table)
            {
                if (maxTime < train.GetTrainTimeOnTheWay()) maxTime = train.GetTrainTimeOnTheWay();
            }

            return maxTime;

        }
        public int GetTrainsCount()
        {
            return AllTrainsTime_table.Count;
        }

        public int GetLastTrainStation(int time, int trainID)
        {

            return AllTrainsTime_table[trainID].GetLastTrainStation(time);
                               
        }

        public bool TrainAtStation(int time, int trainID)
        {
            return AllTrainsTime_table[trainID].TrainAtStation(time);


        }
        public  bool TwoTrainHaveOppositeTransition(int time, int train_one_Id, int train_two_id)
        {
            if (Train.TwoTrainsHaveOppositeTransitionAtOneMoment(time, AllTrainsTime_table[train_one_Id], AllTrainsTime_table[train_two_id])) return true;
            return false;
        }

        public bool TrainExistAtMoment(int time, int trainID)
        {
            if (AllTrainsTime_table[trainID].TrainExistAtMoment(time)) return true;
            return false;
        }
    }
}
