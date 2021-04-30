using System;
using System.Collections.Generic;
using System.Text;

namespace railway.include
{
    class Transition
    {
        int dispatchStationID;
        int arrivalStationID;
        int length;
        public Transition(int dispatchStationID, int arrivalStationID, int length)
        {
            this.dispatchStationID = dispatchStationID;
            this.arrivalStationID = arrivalStationID;
            this.length = length;  
        }
        

        public static bool IsOposite(Transition one, Transition two)
        {
            if ((one.dispatchStationID == two.arrivalStationID) && (one.arrivalStationID == two.dispatchStationID)) return true;
            return false;

        }
    
        public void SetLengthOfTransition (int length)
        {
            this.length = length;

        }
        public int GetLengthOfTransition()
        {
            return this.length;

        }
        public int GetdispatchStationID()
        {
            return this.dispatchStationID;

        }
        public int GetarrivalStationID()
        {
            return this.arrivalStationID;

        }
    }
}
