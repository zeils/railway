using System;
using System.Collections.Generic;
using System.Text;
using railway.include;
using System.IO;

namespace railway.source
{
    abstract class GetConfiguration
    {
        private static string path = @"..\..\..\data\configuration.txt";

        public static Configuration Read()
        {

            Configuration new_configuration = new Configuration();
            string line;
            StreamReader file = new StreamReader(path);
            while ((line = file.ReadLine()) != null)
            {
                try 
                {
                    int[] nums = Array.ConvertAll(line.Split(new char[] { ' ' }), int.Parse);
                    Transition new_transition_1 = new Transition(nums[0], nums[1], nums[2]);
                    Transition new_transition_2 = new Transition(nums[1], nums[0], nums[2]);
                    new_configuration.AddTransition(new_transition_1);
                    new_configuration.AddTransition(new_transition_2);


                    
                }
                catch
                {
                    Console.WriteLine("Ошибка чтения Config");
                }
            }  
            return new_configuration;
        }
    }
}
