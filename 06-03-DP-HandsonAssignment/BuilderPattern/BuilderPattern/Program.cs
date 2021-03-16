using System;

namespace BuilderPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Director d1 = new Director();
            Builder b1 = new ChildPackage();
            Builder b2 = new AdultPackage();

            
            d1.GiveOrder(b1);
            Product p1 = b1.GetProduct();
            p1.show();
            


            d1.GiveOrder(b2);
            Product p2 = b2.GetProduct();
            p2.show();

        }
    }
}
