using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TweetApp
{
    class UserStats : Account
    {
      

        public int Countfollowers { get; set; }
       public int CountFavorites { get; set; }
       public string ScreenName { get; set; }
        public string UserName { get; set; }
        public dynamic Json(JsonUser jsonUser)
        {
            UserStats userStats = JsonConvert.DeserializeObject<UserStats>(jsonUser.JsonU);
            JObject UserAttributes = JObject.Parse(jsonUser.JsonU);
            UserName = UserAttributes.SelectToken("Name").ToString();
            Countfollowers = (int)UserAttributes.SelectToken("FollowersCount");
            ScreenName = UserAttributes.SelectToken( "ScreenName" ).ToString();
            CountFavorites = (int)UserAttributes.SelectToken("FavouritesCount");
            return UserAttributes;
        }

        



    }
}
