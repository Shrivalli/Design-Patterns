using System;

namespace AdpterPattern
{
    public class MovableAdapterImpl : IMovableAdapter

    {

       
        private readonly IMovable luxuryCars;

        public MovableAdapterImpl(IMovable movable)
        {
            luxuryCars = movable;
        }

        public double Price()
        {
            return USDtoEuro(luxuryCars.GetPrice());
        }

        private double USDtoEuro(double v)
        {
            return v * 25;
        }

        public double Speed()
        {
            return MPHtoKMPH(luxuryCars.GetSpeed());
        }
        private double MPHtoKMPH(double luxuryCars)
        {
            return luxuryCars * 1.60934;
        }
    }
}
