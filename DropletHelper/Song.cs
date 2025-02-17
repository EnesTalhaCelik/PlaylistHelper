using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DropletHelper
{
    internal class Song
    {

        string SongName { get; }

        string SongLink { get;}

        string SongCreator { get; }
        Dictionary<string,int> Token {get;}

        public Song(string songname,string link,string creator)
        {
            
            SongName = songname;
            SongLink = link;
            SongCreator = creator;

            TokenizeSong(SongName,SongCreator);



        }
        public Song(string songname,string creator)
        {



        }
        public Song(string songname)
        {



        }

        private void TokenizeSong(string name,string creator)
        {


        }

        private void TokenizeSong(string name)
        {


        }

    }
}
