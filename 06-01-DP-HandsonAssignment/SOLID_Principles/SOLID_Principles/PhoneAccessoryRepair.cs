using System;

namespace SOLID_Principles
{
    class PhoneAccessoryRepair : IRepair
    {
        public void ProcessAccessoryRepair(string accessoryType)
        {
            Console.WriteLine(string.Format("{0} repair accepted!", accessoryType));
        }
        public void ProcessPhoneRepair(string modelName)
        {
            Console.WriteLine(string.Format("{0} repair accepted!", modelName));
        }
    }
}