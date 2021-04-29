using System;
using System.Collections.Generic;
using System.Text;

namespace railway.source
{
    class Way
    {
        private int station1;
        private int station2;
        private int length;

        public int Station1 { get { return station1; } }
        public int Station2 { get { return station2; } }
        public int Length { get { return length; } }

        public Way(int station1, int station2, int length)
        {
            this.station1 = station1;
            this.station2 = station2;
            this.length = length;

        }





    }
}
