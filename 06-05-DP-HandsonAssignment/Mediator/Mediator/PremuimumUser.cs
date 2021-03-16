using System;

namespace Mediator
{
    class PremuimumUser : IUser
    {
        string name;
        IChatMediator chat;

        public PremuimumUser(string Name, IChatMediator Chat)
        {
            this.name = Name;
            this.chat = Chat;
        }
        public void RecevieMessage(string msg)
        {
            Console.WriteLine("Premuimum User --{0} \n recevied message : {1}", name, msg);
        }

        public void SendMessage(string msg)
        {
            chat.SendMessage(msg, this);
        }
    }
}
