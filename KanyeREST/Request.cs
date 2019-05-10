using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace KanyeREST
{
    class Request
    {
        /*
         * MS: This is where you could / should have encapsulated the title 
         * as well as the response here rather than passing in and returning a string. 
         * It's admittedly overkill... but you could imagine passing in an object with a title
         * that gets the response populated.  Or you could set a property on the Request... 
         * any number of ways. 
         */
        public String GetResponse(string title)
        {
            WebClient client = new WebClient();
            String downloadedString = client.DownloadString("http://www.kanyerest.xyz/api/track/" + title);
            return downloadedString;
        }
    }
}
