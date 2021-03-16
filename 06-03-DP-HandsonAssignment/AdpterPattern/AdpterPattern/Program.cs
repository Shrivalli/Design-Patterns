using System;

namespace AdpterPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            IMovable bugatti = new BugatiVeryon();
            IMovableAdapter adapter = new MovableAdapterImpl(bugatti);
            Console.WriteLine("Speed in MPH");
            Console.WriteLine(bugatti.GetSpeed());

            Console.WriteLine("Speed in KMPH");

            Console.WriteLine(adapter.Speed());

            Console.WriteLine("Price in USD");
            Console.WriteLine(bugatti.GetPrice());


            Console.WriteLine("Price in Euro");
            Console.WriteLine(adapter.Price());

            
        }
    }
}
