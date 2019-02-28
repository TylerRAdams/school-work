using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TweetApp
{
    class PMSender: IMessageSender
    {
        public void SendMessage(Message PrivateMessage, String User)
        {
            Account account = new Account();
            String PM = PrivateMessage.Content;
            Tweetinvi.Auth.SetUserCredentials(account.masterCredentials[0], account.masterCredentials[1], account.masterCredentials[2], account.masterCredentials[3]);
            var Recepient = Tweetinvi.User.GetUserFromScreenName(User);     
            try
            {
                var Message = Tweetinvi.Message.PublishMessage(PM, Recepient);
                var isPublished = Message.IsMessagePublished;
                if (isPublished)
                {
                    System.Windows.MessageBox.Show("You have sent the message: " + PrivateMessage.Content + " to: @" + User);
                }
            }
            catch
            {
                System.Windows.MessageBox.Show("Message failed to send.");
            }
        }
    }
}