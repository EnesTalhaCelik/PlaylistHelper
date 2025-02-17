using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;



namespace DropletHelper
{
    internal static class DropletHelper
    {
        internal static string SpotifyToken;

        private static async void initializeProgram()
        {



            using (StreamReader sr = new StreamReader("config.json"))
            {
                string json = await sr.ReadToEndAsync();
                JSONStructure data = JsonConvert.DeserializeObject<JSONStructure>(json);

                SpotifyToken = data.SpotiToken;

            }

        }

        internal sealed class JSONStructure
        {
            internal string SpotiToken { get; set; }
            
        }






    }
}
