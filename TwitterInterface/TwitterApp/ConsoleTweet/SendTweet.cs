using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tweetinvi

namespace ConsoleTweet
{
    class SendTweet
    {
        public void TweetFunction(string tweetMessage)
        {
         
                Auth.SetUserCredentials("6RyameaQdHb58UWgeIdRcJpzJ", "PhfqFS92SuEYO6mN2ru37vhQgmiRsvgJw2O1NtAn7ZLtXvA7gD", "915239441806929921-grOFuq8pprynA0aiAY1xAJYTpoYyDV1", "m3QDkIREbBs0Zz2AOAxLYVQXF14KUGfbxg5pmc7y7TqKq");

                var user = User.GetAuthenticatedUser();

                Tweet.PublishTweet(tweetMessage);

                var timelineTweets = Timeline.GetUserTimeline(user, 5);            
        }
    }
}

