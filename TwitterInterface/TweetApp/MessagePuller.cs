using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tweetinvi;

namespace TweetApp
{
    class MessagePuller
    {
        public List<String> PullMessages()
        {
            Account account = new Account();
            Auth.SetUserCredentials(account.masterCredentials[0], account.masterCredentials[1], account.masterCredentials[2], account.masterCredentials[3]);
            var latestMessagesReceived = Tweetinvi.Message.GetLatestMessagesReceived();
            var count = 1;
            List<String> Messages = new List<String>();
            foreach (Tweetinvi.Models.IMessage element in latestMessagesReceived)
            {
                var text = element.ToString();
                Messages.Add(text);
                count++;
            }
            return Messages;
        }
    }
}
