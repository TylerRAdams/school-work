using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TweetApp
{
    class MessageSenderFactory
    {
        public static IMessageSender GetMessageSender(string type)
        {
            IMessageSender sender = null;
            if(type == "tweet")
            {
                sender = new TweetSender();
            }
            else if(type == "pm")
            {
                sender = new PMSender();
            }
            return sender;
        }
    }
}
