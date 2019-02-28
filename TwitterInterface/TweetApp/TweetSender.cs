using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tweetinvi;

namespace TweetApp
{
    class TweetSender: IMessageSender
    {
        public void SendMessage(Message TweetMessage, String Recipient)
        {
            
            String tweet = TweetMessage.Content;
            Account account = new Account();

            Auth.SetUserCredentials(account.masterCredentials[0],account.masterCredentials[1],account.masterCredentials[2],account.masterCredentials[3]);

            var user = User.GetAuthenticatedUser();
            if (TweetMessage.Length <= 140)
            { 
                Tweet.PublishTweet(tweet);
                System.Windows.MessageBox.Show("You have Super Tweeted the message: " + TweetMessage.Content);
                var timelineTweets = Timeline.GetUserTimeline(user, 5);
            }
            else
            {
                System.Windows.MessageBox.Show("Error. You have attempted to Tweet something longer than 140 characters.", "Error!");
            }
        }
        
    }
}
