using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TweetApp
{
    interface IMessageSender
    {
        void SendMessage(Message message, String recipient);
    }
}
