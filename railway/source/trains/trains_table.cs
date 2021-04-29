using System;
using System.Collections.Generic;
using System.Text;

namespace railway.source.trains
{
    class trains_table
    {

        private List<Train> time_table = new List<Train>();

        public trains_table()
        {

        }

      


        public void AddTrainToTable(Train t)
        {
            time_table.Add(t);

        }

    }
}
