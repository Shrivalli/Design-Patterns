using System;

namespace Mediator
{
    class Program
    {
        static void Main(string[] args)
        {
            IChatMediator chatMediator = new ChatMediator();
            IUser user1 = new BasicUser("Vamshi", chatMediator);
            IUser user2 = new PremuimumUser("Siri", chatMediator);
            IUser user3 = new BasicUser("Harsha", chatMediator);

            chatMediator.AddUser(user1);
            chatMediator.AddUser(user2);
            chatMediator.AddUser(user3);

            user1.SendMessage("Hello Guys!");
            Console.ReadKey();


        }
    }
}
