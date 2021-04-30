using System;
using System.Collections.Generic;
using System.Text;
using railway.include;
namespace railway.source
{
    class CheckingTrainsСompatibility
    {
        
        private static TrainTime_table trainTime_Table;
       
        private static bool safe;
        

        static CheckingTrainsСompatibility()
        {
            

            trainTime_Table = GetTrainTime_table.Read();
            safe = true;
            

        }

        public static bool Check()
        {
            CheckAllTrainsInAllTime();
           
            return safe;
        }


       




        private static void CheckAllTrainsInAllTime()
        {
            Console.WriteLine("max time {0}" , trainTime_Table.GetMaximumTimeOfTrainTransition());

            for (int time = 0; time < trainTime_Table.GetMaximumTimeOfTrainTransition(); time++)
            {

                 CheckAllTrainsAtOneMoment(time);

            }

           


        }

        private static void CheckAllTrainsAtOneMoment(int time)
        {
           
           
           
            for (int train_one_Id = 0; train_one_Id < trainTime_Table.GetTrainsCount(); train_one_Id++)
            {
                for (int train_two_Id = 0; train_two_Id < trainTime_Table.GetTrainsCount(); train_two_Id++)
                {
                   
                    bool g = trainTime_Table.TrainExistAtMoment(time, train_one_Id);
                    bool p = trainTime_Table.TrainExistAtMoment(time, train_two_Id);
                    //Console.WriteLine("Time {0} // Train 1 {1}   {2} // Train 2 {3}  {4} /// SAFE {5}", time , train_two_Id, g , train_two_Id,p,safe);

                    if (trainTime_Table.TrainExistAtMoment(time,train_one_Id) && trainTime_Table.TrainExistAtMoment(time, train_two_Id) && (train_one_Id != train_two_Id))
                         CheckTwoTrainsAtOneMoment(time, train_one_Id, train_two_Id);
                    






                }

               




            }
            

        }

        private static void CheckTwoTrainsAtOneMoment(int time , int train_one_id, int train_two_id)
        {
            
            if (trainTime_Table.TrainAtStation(time , train_one_id) && trainTime_Table.TrainAtStation(time, train_two_id))
            {
                if (trainTime_Table.GetLastTrainStation(time, train_one_id) == trainTime_Table.GetLastTrainStation(time, train_two_id))
                    safe = false;
                
                                                                     
            }

            if (trainTime_Table.TwoTrainHaveOppositeTransition(time, train_one_id, train_two_id)) safe = false;

            
            






        }

        



    }
}
