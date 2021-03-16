using System;

namespace AbstractFactory
{
    class Client
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type cartype");
            var type = Console.ReadLine();

            if(type=="Mercedes")
            {
                Factory mer = new MercedesFactory();
                Console.WriteLine(mer.makeTire());
                Console.WriteLine(mer.makeHeadlight());

            }
            else
            {
                Factory mer = new AudiFactory();
                Console.WriteLine(mer.makeTire());
                Console.WriteLine(mer.makeHeadlight());
            }

        }
    }
}
