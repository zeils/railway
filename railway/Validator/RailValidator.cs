using System;
using System.Collections.Generic;
using System.Text;
using RailWay.Common;
using RailWay.Providers;
using RailWay.Validator;


namespace RailWay.Validator
{
    class RailValidator
    {
        
        public bool Validate(string stationDistancesPath, string trainsRoutesPath)
        {
            TrainTime_table trainTime_Table = TrainsRoutesProvider.Read(stationDistancesPath , trainsRoutesPath);
   
            return CheckAllTrainsInAllTime(trainTime_Table);
        }

        private bool CheckAllTrainsInAllTime(TrainTime_table trainTime_Table)
        {            
            for (int time = 0; time < trainTime_Table.GetMaxNumOfTicks(); time++) 
            {
                if (!CheckAllTrainsAtOneMoment(trainTime_Table, time )) return false;
            }
            return true;        
        }

        private bool CheckAllTrainsAtOneMoment(TrainTime_table trainTime_Table, int time )
        {                    
            for (int firstTrain = 0; firstTrain < trainTime_Table.Count-1; firstTrain++)
            {
                for (int secondTrain = firstTrain+1; secondTrain < trainTime_Table.Count; secondTrain++)
                {                                    
                    if (trainTime_Table.TrainExistAtMoment(firstTrain,time) && trainTime_Table.TrainExistAtMoment(secondTrain, time))
                         if(!CheckTwoTrainsAtOneMoment( firstTrain, secondTrain, trainTime_Table, time)) return false;                   
                }            
            }
            return true;        
        }

        private bool CheckTwoTrainsAtOneMoment( int firstTrainNumber, int secondTrainNumber , TrainTime_table trainTime_Table, int tick)
        {           
            if (trainTime_Table.TrainAtStation(firstTrainNumber, tick ) && trainTime_Table.TrainAtStation(secondTrainNumber, tick ))     
                
                if (trainTime_Table.GetLastTrainStation(firstTrainNumber, tick ) == trainTime_Table.GetLastTrainStation(secondTrainNumber, tick ))

                    return false;             


            if (trainTime_Table.TwoTrainIntersecting(firstTrainNumber,secondTrainNumber,tick)) return false;
            return true;
        }    
    }
}
