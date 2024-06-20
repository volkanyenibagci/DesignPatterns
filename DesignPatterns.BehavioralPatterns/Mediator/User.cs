using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BehavioralPatterns.Mediator
{
    // Colleague
    public class User
    {
        private string name;
        private IChatRoomMediator chatMediator;

        public User(string name, IChatRoomMediator chatMediator)
        {
            this.name = name;
            this.chatMediator = chatMediator;
        }

        public string GetName()
        {
            return name;
        }

        public void SendMessage(string message)
        {
            chatMediator.ShowMessage(this, message);
        }
    }
}