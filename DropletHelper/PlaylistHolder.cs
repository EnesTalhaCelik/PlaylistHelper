using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DropletHelper
{
    internal class PlaylistHolder
    {
        string playlistName;

        Dictionary<string, Song> ListOfMusic = new Dictionary<string, Song>();

        void AddSong(Song song)
        {


        }
        ///fix later
        int AddSongWithoutRepeat(Song song)
        {
            if (ListOfMusic[song.SongName] != null)
            {
                return -1;
            }

            ListOfMusic.Add(song.SongName, song);
            song.Equals(song);
            return 0;
        }
    }
}
