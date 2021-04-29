using System;
using railway.Interfaces;
using railway.source;
using railway.data;

namespace railway
{
    class Program
    {
        static void Main(string[] args)
        {
            //Configuration t = new Configuration();
            //t.Read();
            IReadFile r = new Configuration();
            r.Read();
            
            
        }
    }
}
