using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DropletHelper
{
    internal class Song
    {

        public string SongName { get; }

        public string SongLink { get;}

        public string SongCreator { get; }
        Dictionary<string,int> Token {get;}


        public Song(string songname,string link,string creator)
        {
            
            SongName = songname;
            SongLink = link;
            SongCreator = creator;

            TokenizeSong();
        }

        public Song(string songname,string creator)
        {
            SongName = songname;
            SongCreator = creator;

            TokenizeSong();
        }

        public Song(string songname)
        {

            SongName = songname;

            TokenizeSong();
        }



        private void TokenizeSong()
        {
            string[] tokens = Regex.Split(SongName + SongCreator," ");

            foreach (string key in tokens) {
                if (Token[key] == null)
                {
                    Token.Add(key, 1);

                }
                else
                {
                    Token[key] += 1;
                }
            }

        }

      
    }
}
