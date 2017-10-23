using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace we6.spotify.logic
{
    public class SpotifySearch
    {

        public List<String> Search(string term)
        {
            WebClient webClient = new WebClient();
            JObject data = JObject.Parse(webClient.DownloadString("https://api.spotify.com/v1/search?q=" + term + "&type=artist"));

            return data["artists"]["items"].Select(x => (string)x["name"]).ToList();
        }

    }
}
