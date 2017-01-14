using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HueClient
{
    class HueUser
    {
        public String Token;
        public String Host;

        public HueUser(String token, String host)
        {
            Token = token;
            Host = host;
        }
    }
}