using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using railway.Interfaces;
using railway.source;
using railway.source.trains;

namespace railway.data
{
    class Time_table : IReadFile
    {
       
        private string path = @"..\..\..\data\time_table.txt";

        public trains_table Read()
        {
            trains_table new_table = new trains_table();           
            string line;
            StreamReader file = new StreamReader(path);
            while ((line = file.ReadLine()) != null)
            {
                Train new_train = new Train();
                int[] nums = Array.ConvertAll(line.Split(new char[] { ' ' }), int.Parse);
                for (int i = 0; i < nums.Length; i++)
                {
                    new_train.AddStationToTrain(nums[i]);
                }

                new_table.AddTrainToTable(new_train);

            }
            return new_table;
        }



    }
}
