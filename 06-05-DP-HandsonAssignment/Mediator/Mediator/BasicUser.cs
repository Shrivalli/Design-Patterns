using System;

namespace Mediator
{
    class BasicUser : IUser
    {
        string name;
        IChatMediator chat;

        public BasicUser(string Name, IChatMediator Chat)
        {
            this.name = Name;
            this.chat = Chat;
        }
        public void RecevieMessage(string msg)
        {
            Console.WriteLine("Basic User --{0} \n recevied message : {1}", name, msg);
        }

        public void SendMessage(string msg)
        {
            chat.SendMessage(msg, this);
        }
    }
}
