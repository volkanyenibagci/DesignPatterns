using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BehavioralPatterns.Mediator
{
    // Mediator arayüzü
    public interface IChatRoomMediator
    {
        void ShowMessage(User user, string message);
    }
}