using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HueClient
{
    class HueUser
    {
        public String Token { get; set; }

        public HueUser(String token)
        {
            Token = token;
        }
    }
}