using System;
using System.Collections.Generic;
using System.Text;


namespace railway.include
{
    class Train
    {
        private static int speed = 1;
        private List<Transition> allTrainTranstions = new List<Transition>();

 


        public  void AddTransitionToTrain(Transition transition)
        {
            allTrainTranstions.Add(transition);
        }

        public bool TrainAtStation(int time)
        {
            if (time == 0) return true;
            if (allTrainTranstions[time] != allTrainTranstions[time - 1]) return true;
            return false;


        }
        public int GetLastTrainStation(int time)
        {

            return allTrainTranstions[time].GetdispatchStationID();
        }

        public int GetTrainTimeOnTheWay ()
        {
            int time = 0;
            foreach(Transition transition in allTrainTranstions)
            {
                time = time + speed * 1;
                
            }
            return time;
            
        }

        public  static bool TwoTrainsHaveOppositeTransitionAtOneMoment(int time, Train one, Train two)
        {

            if (Transition.IsOposite(one.allTrainTranstions[time], two.allTrainTranstions[time])) return true;
            return false;
            
        }

        public bool TrainExistAtMoment(int time)
        {
          
            if (time >= this.GetTrainTimeOnTheWay()) return false;
            return true;

         
        }

        

        








    }
}
