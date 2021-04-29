using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using railway.Interfaces;
using railway.source;

namespace railway.data
{
     class Configuration: IReadFile
    {
        

        private string path = @"..\..\..\data\configuration.txt";


        public Railway  Read()               
        {

            Railway rail_ways = new Railway();
            string line;
            StreamReader file = new StreamReader(path);
            while ((line = file.ReadLine()) != null)
            {
                int[] nums = Array.ConvertAll(line.Split(new char[] { ' ' }), int.Parse);
                Way new_way = new Way(nums[0], nums[1], nums[2]);
                rail_ways.AddWay(new_way);

            }
            return rail_ways;
        }
    }
}