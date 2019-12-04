using System;
using System.Collections.Generic;

namespace Task3b_oop
{
    class Player
    {
        List<Song> trackList = new List<Song>();

        public void AddSong(Song song)
        {
            trackList.Add(song);
        }

        public void RemoveSongs(int songNumber)
        {
            trackList.RemoveAt(songNumber);
        }

        public void PlaylistSongs()
        {
            foreach (Song item in trackList)
            {
                Console.Clear();
                item.Play();
            }
        }
    }
}
