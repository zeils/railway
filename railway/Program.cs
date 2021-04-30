using System;

using railway.source;


namespace railway
{
    class Program
    {

        

        static void Main(string[] args)
        {

            if (CheckingTrainsСompatibility.Check()) Console.WriteLine("Schedule safe ");
            else Console.WriteLine("Schedule unsafe ");


        }
    }
}
