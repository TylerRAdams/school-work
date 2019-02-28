using System;
using Tweetinvi;

namespace TwitterApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Auth.SetUserCredentials("6RyameaQdHb58UWgeIdRcJpzJ", "PhfqFS92SuEYO6mN2ru37vhQgmiRsvgJw2O1NtAn7ZLtXvA7gD", "	915239441806929921-grOFuq8pprynA0aiAY1xAJYTpoYyDV1", "m3QDkIREbBs0Zz2AOAxLYVQXF14KUGfbxg5pmc7y7TqKq");

            var user = User.GetAuthenticatedUser();
            Console.WriteLine(user);

            var tweet = Tweet.PublishTweet("Hello from Tweetinvi!");

            var timelineTweets = Timeline.GetUserTimeline(user, 5);

            foreach (var timelineTweet in timelineTweets)
            {
                Console.WriteLine(timelineTweet);
            }

            Console.ReadKey();
        }
    }
}
