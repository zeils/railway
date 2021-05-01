using System;
using System.Collections.Generic;
using System.Text;
using railway.include;
using System.IO;

namespace railway.source
{
    abstract class GetTrainTime_table
    {
       private static string path;
       private static Configuration configuration;

        static GetTrainTime_table()
        {
            
            path = @"..\..\..\data\time_table.txt";
            
            configuration = GetConfiguration.Read();

        }


        public static TrainTime_table Read()
        {
            int n = 1;
            TrainTime_table trainTime_Table = new TrainTime_table();
            string line;
            StreamReader file = new StreamReader(path);
            while ((line = file.ReadLine()) != null)
            {
                try
                {
                    Train new_train = new Train();
                    int[] nums = Array.ConvertAll(line.Split(new char[] {' '}), int.Parse);
                 
                    Train train = new Train();

                    for (int i = 0; i < nums.Length - 1; i++)
                    {
                        

                        Transition transition = new Transition(nums[i], nums[i + 1], configuration.FindLengthOfTransition(nums[i], nums[i + 1]));
                        for (int j = 0; j < configuration.FindLengthOfTransition(nums[i], nums[i + 1]); j++)
                        {
                            train.AddTransitionToTrain(transition);
                        }

                    }


                    trainTime_Table.AddTrainToTime_table(train);
                }
                catch
                {
                    Console.WriteLine("Ошибка чтения расписания");
                }

            }
            return trainTime_Table;
        }

    }
}
