using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HueClient
{
    class Light
    {
        public String Name;
        public String Id;
        public LightState State;

        public Light(HttpClient http, String id,String name, LightState state)
        {
            Id = id;
            Name = name;
            state.SetLight(this);
            state.SetHttpClient(http);
            State = state;
        }

        public void SetUser(HueUser user)
        {
            State.SetUser(user);
        }
    }
}
