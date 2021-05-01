using System;
using System.Collections.Generic;
using System.Text;

namespace railway.include
{
    class Configuration
    {
        private static List<Transition> AllPosibleTransitions;

       

        public Configuration()
        {
            
            AllPosibleTransitions = new List<Transition>();
        }


        
        

        public void AddTransition (Transition transition)
        {
            AllPosibleTransitions.Add(transition);
        }

        public int FindLengthOfTransition(int dispatchStationID, int arrivalStationID)
        {
            foreach (Transition transition in AllPosibleTransitions)
            {
                if ((dispatchStationID == transition.GetdispatchStationID()) && (arrivalStationID == transition.GetarrivalStationID())) return transition.GetLengthOfTransition();

            }

            return 0;
        }


    }
}
