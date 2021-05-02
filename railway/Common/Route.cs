

namespace RailWay.Common
{
    class Route
    {
        private int dispatchStationNumber;
        private int arrivalStationNumber;
        private int length;

        public int DispatchStationNumber { get { return dispatchStationNumber; } }
        public int ArrivalStationNumber { get { return arrivalStationNumber; } }
        public int Length { get { return length; } }
        public Route(int dispatchStationNumber, int arrivalStationNumber, int length)
        {
            this.dispatchStationNumber = dispatchStationNumber;
            this.arrivalStationNumber = arrivalStationNumber;
            this.length = length;
        }



        public bool IsIntersecting(Route route)
        {
            if ((dispatchStationNumber == route.arrivalStationNumber) && (arrivalStationNumber == route.dispatchStationNumber))
            {
                return true;
            }
            return false;
        }

        public bool IsSameRoute(int dispatchStationNumber, int arrivalStationNumber)
        {
            if ((this.dispatchStationNumber == dispatchStationNumber) && (this.arrivalStationNumber == arrivalStationNumber))
            {
                return true;
            }
            return false;


        }

    }
}
