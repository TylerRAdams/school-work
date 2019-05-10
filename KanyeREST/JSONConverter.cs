using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KanyeREST
{
    class JSONConverter
    {
        /*
         * MS: Great example of encapsulating both the parameter and the return 
         * variable.
         */
        public Song Convert(JsonInput input)
        {
                Song thisSong = JsonConvert.DeserializeObject<Song>(input.Json);
                return thisSong;
        }
    }
}

