using System;
using System.Collections.Generic;
using System.Text;
using RailWay.Common;
using RailWay.Providers;
using RailWay.Validator;
using System.IO;

namespace RailWay.Providers
{
    static class CommonProvider
    {
        public static List<string> Read(string path)
        {
            List<string> lines = new List<string>();
            string line;
            StreamReader file = new StreamReader(path);
            while ((line = file.ReadLine()) != null)
            {
                lines.Add(line);
            }
            return lines;
        }        
    }
}
