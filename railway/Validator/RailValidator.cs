using RailWay.Common;
using RailWay.Providers;



namespace RailWay.Validator
{
    static class RailValidator
    {
        
        public static bool Validate(string stationDistancesPath, string trainsRoutesPath)
        {
            TrainTimeTable trainTime_Table = TrainsRoutesProvider.Read(stationDistancesPath , trainsRoutesPath);
   
            return CheckAllTrainsInAllTime(trainTime_Table);
        }

        private static bool CheckAllTrainsInAllTime(TrainTimeTable trainTime_Table)
        {            
            for (int tick = 0; tick < trainTime_Table.GetMaxNumOfTicks(); tick++) 
            {
                if (!CheckAllTrainsAtOneMoment(trainTime_Table, tick )) return false;
            }
            return true;        
        }

        private static bool CheckAllTrainsAtOneMoment(TrainTimeTable trainTime_Table, int tick )
        {
            int trainTimeTableCount = trainTime_Table.Count;
            for (int firstTrain = 0; firstTrain < trainTimeTableCount - 1; firstTrain++)
            {
                for (int secondTrain = firstTrain+1; secondTrain < trainTimeTableCount; secondTrain++)
                {                                    
                    if (trainTime_Table.TrainExistAtMoment(firstTrain,tick) && trainTime_Table.TrainExistAtMoment(secondTrain, tick))
                         if(!CheckTwoTrainsAtOneMoment( firstTrain, secondTrain, trainTime_Table, tick)) return false;                   
                }            
            }
            return true;        
        }

        private static bool CheckTwoTrainsAtOneMoment( int firstTrainNumber, int secondTrainNumber , TrainTimeTable trainTime_Table, int tick)
        {           
            if (trainTime_Table.TrainAtStation(firstTrainNumber, tick ) && trainTime_Table.TrainAtStation(secondTrainNumber, tick ))     
                
                if (trainTime_Table.GetLastTrainRoute(firstTrainNumber, tick ) == trainTime_Table.GetLastTrainRoute(secondTrainNumber, tick ))

                    return false;             


            if (trainTime_Table.TwoTrainIntersecting(firstTrainNumber,secondTrainNumber,tick)) return false;
            return true;
        }    
    }
}
