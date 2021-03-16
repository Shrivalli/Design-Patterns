using System.Collections.Generic;

namespace Mediator
{
    class ChatMediator : IChatMediator
    {
        List <IUser> users;

        public ChatMediator()
        {
            users = new List<IUser>();
        }
        public void AddUser(IUser user)
        {
            users.Add(user);
        }

        public void SendMessage(string msg, IUser sender)
        {
            foreach(IUser user in users)
            {
                if(user!=sender)

                {
                    user.RecevieMessage(msg);
                }
            }
        }
    }
}
