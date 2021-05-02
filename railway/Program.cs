using System;
using RailWay.Validator;


namespace RailWay
{
    class Program
    {
        private const string stationDistancesPath = @"..\..\..\data\\StationDistances.txt";
        private const string trainsRoutesPath = @"..\..\..\data\TrainsRoutes.txt";


        static void Main(string[] args)
        {
           
            if (RailValidator.Validate(stationDistancesPath, trainsRoutesPath)) Console.WriteLine("Schedule safe ");
            else Console.WriteLine("Schedule unsafe ");


        }
    }
}
