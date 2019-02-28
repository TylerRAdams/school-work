using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tweetinvi;
using Tweetinvi.Models;
using System.Windows.Controls;

namespace TweetApp
{
    class Profile : UserStats
    {

        public int Followers ()
        {
           int followers = Countfollowers;
            return followers;
        }
        public int Favorites()
        {
            int favorites = CountFavorites;
            return favorites;
        }
        public string ScrnName()
        {
            string scrnname = ScreenName;
            return scrnname;
        }
        public string Name()
        {
            string name = UserName;
            return name;
        }
       
          
    }
        




    
}
