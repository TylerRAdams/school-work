using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tweetinvi;

namespace TweetApp
{
    class TimelinePuller
    {
        public List<String> PullTimeline()
        {
            Account account = new Account();
            Auth.SetUserCredentials(account.masterCredentials[0], account.masterCredentials[1], account.masterCredentials[2], account.masterCredentials[3]);
            var tweets = Timeline.GetHomeTimeline();
            var count = 1;
            List<String> TimelineTweets = new List<String>();
            foreach (Tweetinvi.Models.ITweet element in tweets)
            {
                var text = element.ToString();
                TimelineTweets.Add(Environment.NewLine + count + ".) " + text);
                count++;
            }
            return TimelineTweets;
        }
    }
}
