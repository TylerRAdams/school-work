using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TweetApp
{
    class TweetMessage: Message
    {
        public int Likes { get; set; }
        public int Retweets { get; set; }
    }
}
